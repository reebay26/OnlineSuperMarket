using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineSuperMarket.Dbwork;
using OnlineSuperMarket.Models;
using System.Diagnostics;
using System.Linq;

namespace OnlineSuperMarket.Controllers
{
    public class CartController : Controller
    {
        private readonly sqlDb db;

        public CartController(sqlDb db)
        {
            this.db = db;
        }

        public IActionResult AddToCart(int productId, int quantity)
        {
            if (HttpContext.Session.GetString("UserId") == null)
            {
                TempData["Error"] = "Please login first to add items to cart.";
                return RedirectToAction("Login", "web");
            }

            int userId = int.Parse(HttpContext.Session.GetString("UserId"));  // Convert string to int

            var product = db.tbl_product.Find(productId);
            if (product == null)
            {
                return NotFound();
            }

            var cartItem = db.Cart.FirstOrDefault(c => c.Product_id == productId && c.User_id == userId);

            if (cartItem == null)
            {
                cartItem = new Cart_Model
                {
                    User_id = userId,
                    Product_id = productId,
                    Quantity = quantity,
                    TotalPrice = product.ProductPrice * quantity
                };
                db.Cart.Add(cartItem);
            }
            else
            {
                cartItem.Quantity += quantity;
                cartItem.TotalPrice = cartItem.Quantity * product.ProductPrice;
            }

            db.SaveChanges();
            return RedirectToAction("Shop_cart", "web");
        }

        public IActionResult Index()
        {
            var userIdString = HttpContext.Session.GetString("UserId");

            if (userIdString == null)
            {
                Debug.WriteLine("User is not logged in.");
                TempData["Error"] = "Please login first to view your cart.";
                return RedirectToAction("Login", "web");
            }

            int userId = int.Parse(userIdString);  // Convert session string to int

            var cartItems = db.Cart
                .Where(c => c.User_id == userId)
                .Include(c => c.Product)  // Ensure product details are loaded
                .ToList();

            Debug.WriteLine($"User ID: {userId}");
            Debug.WriteLine($"Cart Items Count: {cartItems.Count}");

            foreach (var item in cartItems)
            {
                Debug.WriteLine($"Cart Item ID: {item.CartId}, Product ID: {item.Product_id}, Product: {(item.Product != null ? item.Product.ProductName : "NULL")}");
            }

            return View(cartItems);
        }

        public IActionResult RemoveFromCart(int cartId)
        {
            if (HttpContext.Session.GetString("UserId") == null)
            {
                return RedirectToAction("Login", "web");
            }

            var cartItem = db.Cart.Find(cartId);

            if (cartItem != null)
            {
                db.Cart.Remove(cartItem);
                db.SaveChanges();
            }

            return RedirectToAction("Shop_cart","web");
        }

        [HttpPost]
        public IActionResult UpdateCart(int cartId, int quantity)
        {
            if (HttpContext.Session.GetString("UserId") == null)
            {
                return Json(new { success = false, message = "Please login first." });
            }

            var cartItem = db.Cart.Include(c => c.Product).FirstOrDefault(c => c.CartId == cartId);

            if (cartItem == null)
            {
                return Json(new { success = false, message = "Cart item not found." });
            }

            if (quantity <= 0)
            {
                // Remove from cart if quantity becomes zero
                db.Cart.Remove(cartItem);
                db.SaveChanges();
                return Json(new { success = true, message = "Item removed from cart." });
            }

            int availableStock = cartItem.Product.ProductQuantity;

            if (quantity > availableStock)
            {
                return Json(new { success = false, message = "Not enough stock available." });
            }

            int previousQuantity = cartItem.Quantity; // Pehle ki quantity store karlo
            cartItem.Quantity = quantity;
            cartItem.TotalPrice = cartItem.Product.ProductPrice * quantity;

            // Stock adjust karne ka sahi tareeqa:
            cartItem.Product.ProductQuantity -= (quantity - previousQuantity);

            db.SaveChanges();
            return Json(new { success = true });
        }


        public IActionResult CartSummary()
        {
            if (HttpContext.Session.GetString("UserId") == null)
            {
                return Json(new { itemCount = 0, totalPrice = 0 });
            }

            int userId = int.Parse(HttpContext.Session.GetString("UserId"));  // Convert session string to int

            var cartItems = db.Cart.Where(c => c.User_id == userId).ToList();
            int itemCount = cartItems.Sum(c => c.Quantity);
            decimal totalPrice = cartItems.Sum(c => c.TotalPrice);

            return Json(new { itemCount, totalPrice });
        }
        
    }
}
