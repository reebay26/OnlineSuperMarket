using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineSuperMarket.Dbwork;

namespace OnlineSuperMarket.Controllers
{
  
    public class categoryController : Controller
    {
        sqlDb db;
        public categoryController(sqlDb db)
        {
            this.db = db;

        }
        public IActionResult Grocery_category(int category_id)
        {

            // Find category by ID
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); 
            }

    
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

    
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Vegetables_category( int category_id)
        {// Find category by ID
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Fruits_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Meat_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Footwear_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Stationary_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Dairy_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Cosmetics_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Snacks_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Electronics_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
           
        }


        public IActionResult Women_cloth_category(int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }


        public IActionResult Men_cloth_category (int category_id)
        {
            var category = db.category.FirstOrDefault(c => c.category_id == category_id);

            if (category == null)
            {
                return NotFound(); // If category not found, return 404
            }

            // Fetch products for this category
            var products = db.tbl_product.Where(p => p.product_category == category_id).ToList();

            // Pass category name & products to the view
            ViewBag.CategoryName = category.category_name;
            return View(products);
        }
        [HttpGet]
        [Route("Search")]

        public IActionResult Search(string Search_input)
        {
            if (string.IsNullOrWhiteSpace(Search_input))
            {
                // Agar input empty hai to sab products show karo
                var allProducts = db.tbl_product
                    .Include(p => p.Category)
                    .Include(p => p.brand)
                    .ToList();
                return View("Search", allProducts);
            }

            string searchLower = Search_input.Trim().ToLower(); // Trim spaces and make lowercase

            var products = db.tbl_product
                .Include(p => p.Category)
                .Include(p => p.brand)
                .Where(p =>
                    p.ProductName.ToLower().Contains(searchLower) ||
                    (p.Category != null && p.Category.category_name.ToLower().Contains(searchLower)) ||
                    (p.brand != null && p.brand.brand_name.ToLower().Contains(searchLower))
                )
                .ToList();

            return View("Search", products);
        }



    }
}
