using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using OnlineSuperMarket.Dbwork;
using OnlineSuperMarket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Net.Mail;
using System.Net;
using Newtonsoft.Json;

namespace OnlineSuperMarket.Controllers
{
    public class webController : Controller
    {
        sqlDb db;
        public webController(sqlDb db)
        {
            this.db = db;
        }
        public IActionResult Home()
        {
            var prodname = "vegetables";
            var fetchdata = db.tbl_product.Where(p => p.Category.category_name == prodname).ToList();
            if (fetchdata.Any()) 
            {
                ViewBag.storedproduct = fetchdata;
            }

            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact con)
        {
            db.tbl_contact.Add(con);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }
        public IActionResult Chechout()
        {
            int userId = int.Parse(HttpContext.Session.GetString("UserId"));
            var cartItems = db.Cart
                     .Include(c => c.Product)
                     .Where(c => c.User_id == userId) // Current user ka cart
                     .ToList();

            ViewBag.CartItems = cartItems;
            ViewBag.TotalPrice = cartItems.Sum(c => c.TotalPrice);
            HttpContext.Session.SetString("CartItems", JsonConvert.SerializeObject(cartItems));
            HttpContext.Session.SetString("TotalPrice", cartItems.Sum(c => c.TotalPrice).ToString());
            return View();
        }
        [HttpPost]
        public IActionResult chechout(Order_Model customer_order)
        {
            // ✅ Step 1: Cart Data Fetch Karein
            string cartData = HttpContext.Session.GetString("CartItems");
            if (!string.IsNullOrEmpty(cartData))
            {
                var cartItems = JsonConvert.DeserializeObject<List<Cart_Model>>(cartData);

                // ✅ Step 2: Convert Cart Items into Order_Items
                foreach (var item in cartItems)
                {
                    var orderItem = new Order_Items
                    {
                        Product_id = item.Product.Product_id,
                        Quantity = item.Quantity,
                        TotalPrice = item.TotalPrice
                    };

                    customer_order.Order_Items.Add(orderItem); // ✅ Add directly in Order_Model
                }
            }

            // ✅ Step 3: Save Order with Items
            db.tbl_Order.Add(customer_order);
            db.SaveChanges(); 

            // ✅ Step 4: Save Order ID in Session
            HttpContext.Session.SetInt32("orderId", customer_order.Order_id);
          

            ModelState.Clear();

            return View();
        }

        public IActionResult Shop_details(int Product_id)
        {
            var product_detail = db.tbl_product.FirstOrDefault(p => p.Product_id == Product_id);

            if (product_detail != null)
            {
                ViewBag.products = product_detail;

                if (HttpContext.Session.GetString("UserId") != null)
                {
                    int userId = int.Parse(HttpContext.Session.GetString("UserId"));

                    var cartItem = db.Cart.FirstOrDefault(c => c.Product_id == Product_id && c.User_id == userId);
                    ViewBag.cartItem = cartItem;  
                }
            }

            return View();
        }

        public IActionResult Shop_cart()
        {
            if (HttpContext.Session.GetString("UserId") == null)
            {
                TempData["Error"] = "Please login first to view your cart.";
                return RedirectToAction("Login", "web");
            }

            int userId = int.Parse(HttpContext.Session.GetString("UserId"));
            var cartItems = db.Cart
                .Where(c => c.User_id == userId)
                .Include(c => c.Product)
                .ToList();

            return View(cartItems);
        }

        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(Register_model reg)
        {



            db.register.Add(reg);
            db.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("login", "web");
        }



        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login( string User_email, string User_password)
        {

            var user = db.register.FirstOrDefault(r => r.User_email == User_email && r.User_password ==
          User_password);

            if (user != null)
            {
                HttpContext.Session.SetString("UserId",Convert.ToString( user.User_id));
                HttpContext.Session.SetString("UserEmail", user.User_email);
                HttpContext.Session.SetString("UserName", user.User_name);

                if (user.User_role == "customer")
                {
                    return RedirectToAction("Home", "web");
                }
                else
                {
                    return RedirectToAction("admin_Index", "Admin");
                }
            }
            else { 
                ViewBag.ErrorMessage = "Invalid Email or Password!";
                return View();
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult Forgot_Password()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Forgot_Password(string User_email)

        {
            var user = db.register.FirstOrDefault(u => u.User_email == User_email);

            if (user == null)
            {
                ViewBag.Message = "Email not found!";
                return View();
            }
            string otp = new Random().Next(100000, 999999).ToString();
            user.ResetToken = otp;
            user.ResetTokenExpiry = DateTime.Now.AddMinutes(5); 
            db.SaveChanges();
            SendOTPEmail(User_email, otp);

            // ✅ OTP Page pr Redirect
            TempData["Email"] = User_email;
            return RedirectToAction("Otp");
        }
        private void SendOTPEmail(string User_email, string otp)
        {
            string subject = "Your OTP Code";
            string body =  $@"
    <div style='font-family: Arial, sans-serif; padding: 20px; border: 1px solid #ddd; border-radius: 8px; background-color: #f9f9f9;'>
        <h2 style='color: #d32f2f; text-align: center;'>🔒 Password Reset Request</h2>
        <p>Dear User,</p>
        <p>We received a request to reset your password. Please use the OTP code below to proceed with resetting your password:</p>

        <div style='text-align: center; padding: 15px; background: #fff; border: 2px dashed #d32f2f; border-radius: 10px; font-size: 24px; font-weight: bold; color: #d32f2f;'>
            {otp}
        </div>

        <p>This OTP is valid for <b>5 minutes</b>. Please do not share this code with anyone for security reasons.</p>

        <p>If you did not request this, please ignore this email.</p>

        <p style='margin-top: 20px;'>Best Regards,<br><b>Ogani Support Team</b></p>

        <div style='text-align: center; margin-top: 20px; font-size: 12px; color: #888;'>
            &copy; 2025 Ogani. All rights reserved.
        </div>
    </div>";
            ;

            MailMessage message = new MailMessage();
            message.From = new MailAddress("oganiofficial@gmail.com");
            message.To.Add(User_email);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("oganiofficial@gmail.com", "mxds xoka ykln ueko");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
        public IActionResult Otp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Otp(string otp)
        {
            string email = TempData["Email"]?.ToString();
            if (email == null) return RedirectToAction("ForgotPassword");

            var user = db.register.FirstOrDefault(u => u.User_email == email && u.ResetToken == otp && u.ResetTokenExpiry > DateTime.Now);

            if (user == null)
            {
                ViewBag.Message = "Invalid or expired OTP!";
                return View();
            }

            // ✅ OTP Correct hai, allow reset password
            TempData["Email"] = email;
            return RedirectToAction("Confirm_Password");
           
        }



        public IActionResult ResendOTP()
        {
            string email = TempData["Email"]?.ToString();
            if (string.IsNullOrEmpty(email))
                return RedirectToAction("Forgot_Password");

            var user = db.register.FirstOrDefault(u => u.User_email == email);
            if (user == null)
            {
                ViewBag.Message = "No user found with this email!";
                return RedirectToAction("Forgot_Password");
            }

            // ✅ Naya OTP Generate karo
            string newOtp = new Random().Next(100000, 999999).ToString();
            user.ResetToken = newOtp;
            user.ResetTokenExpiry = DateTime.Now.AddMinutes(5);
            db.SaveChanges();

            // ✅ Naya OTP Email bhejo
            SendOTPEmail(user.User_email, newOtp);

            ViewBag.Message = "A new OTP has been sent to your email!";
            return RedirectToAction("Otp");
        }





        public IActionResult Confirm_Password()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Confirm_Password(string User_password)
        {
            string email = TempData["Email"]?.ToString();
            if (email == null) return RedirectToAction("ForgotPassword");

            var user = db.register.FirstOrDefault(u => u.User_email == email);

            if (user == null)
            {
                ViewBag.Message = "Something went wrong!";
                return View();
            }

            user.User_password = User_password; 
            user.ResetToken = null;
            user.ResetTokenExpiry = null;
           db.SaveChanges();

            return RedirectToAction("Login");
          
        }
    }

 
    }
