using Fingers10.ExcelExport.ActionResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using OnlineSuperMarket.Dbwork;
using OnlineSuperMarket.Models;

namespace OnlineSuperMarket.Controllers
{
    public class AdminController : Controller
    {
        
        sqlDb db;
        IWebHostEnvironment env;
        public AdminController(sqlDb db, IWebHostEnvironment env)
        {
            this.db = db;
            this.env = env;
        }   
      

        public IActionResult admin_Index()
        {
        
            return View();
            
        }
        public IActionResult Add_products()
        {
            var categories = db.category.ToList();
            var brands = db.tbl_brand.ToList();

            ViewBag.Category = categories;
            ViewBag.Brand = brands;
            return View();
        }

        [HttpPost]
        public IActionResult Add_products(Product_Model pro , IFormFile ProductImage)
        {
            string fileName = "";
            var file_extension = Path.GetExtension(ProductImage.FileName).ToLower();
            if (file_extension != ".jpg" && file_extension != ".png" && file_extension != ".jpeg" && file_extension != ".Webp")
            {
                ViewBag.imageError = "file Method Not Supported";
            }
            else {
              
                string location = Path.Combine(env.WebRootPath, "ProductImages");
                fileName = Guid.NewGuid().ToString() + "_" + ProductImage.FileName;
                string filepath = Path.Combine(location, fileName);
                ProductImage.CopyTo(new FileStream(filepath, FileMode.Create));
            }
//for storing this productImage in db//
            pro.ProductImage = fileName;



            if (string.IsNullOrEmpty(pro.product_brand.ToString()))
            {
                pro.product_brand = null; 
            }

            db.tbl_product.Add(pro);
            db.SaveChanges();
            ViewBag.Category = db.category.ToList();
            ViewBag.Brand = db.tbl_brand.ToList();
            ModelState.Clear();
            return View();
        }
        public IActionResult Update_product(int product_id)
        {
               var categories = db.category.ToList();
            var brands = db.tbl_brand.ToList();

            ViewBag.Category = categories;
            ViewBag.Brand = brands;
          
            var products = db.tbl_product.Find(product_id);
            return View(products);
        }
        [HttpPost]
        public IActionResult Update_product(Product_Model pro, IFormFile ProductImage)
        {
            string fileName = "";
            var file_extension = Path.GetExtension(ProductImage.FileName).ToLower();
            if (file_extension != ".jpg" && file_extension != ".png" && file_extension != ".jpeg")
            {
                ViewBag.imageError = "file Method Not Supported";
            }
            else
            {

                string location = Path.Combine(env.WebRootPath, "ProductImages");
                fileName = Guid.NewGuid().ToString() + "_" + ProductImage.FileName;
                string filepath = Path.Combine(location, fileName);
                ProductImage.CopyTo(new FileStream(filepath, FileMode.Create));
            }
            //for storing this productImage in db//
            pro.ProductImage = fileName;
            if (pro != null) {
                db.tbl_product.Update(pro);
                db.SaveChanges();
            }
       
            return RedirectToAction("Product_details");
        }

        [HttpPost]
        public IActionResult Delete_products(int Product_id)
        {
            var dlt_id = db.tbl_product.Find(Product_id);
            if (dlt_id != null)
            {
                db.tbl_product.Remove(dlt_id);
                db.SaveChanges();
            }
            return RedirectToAction("Product_details");
        }

        public IActionResult Product_details()
        {
          var products=  db.tbl_product.ToList();
            return View(products);
        }
        public IActionResult Add_category()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add_category(Category cat)
        {
            db.category.Add(cat);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }


        public IActionResult Edit_category(int category_id)
        {
            var category = db.category.Find(category_id);

            if (category == null)
            {
                return NotFound(); 
            }

            return View(category); 
        }

      
        [HttpPost]
        public IActionResult Edit_category(Category cate)
        {
            if (!ModelState.IsValid)
            {
                return View(cate); 
            }
            db.category.Update(cate);
          

            db.SaveChanges();

            return RedirectToAction("Category_details"); 
        }

        [HttpPost]
        public IActionResult Delete_category(int category_id)
        {
            var dlt_id = db.category.Find(category_id);
            if (dlt_id != null)
            {
                db.category.Remove(dlt_id);
                db.SaveChanges();
            }
            return RedirectToAction("Category_details");
        }


        public IActionResult Category_details(Category cat)
        {
          var category=  db.category.ToList();
            return View(category);
        }



        public IActionResult Add_brand()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add_brand(Brand brand)
        {
            db.tbl_brand.Add(brand);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }

        
        public IActionResult Update_brand(int brand_id)
        {
            var brand = db.tbl_brand.Find(brand_id);
          
            return View( brand);
        }

        [HttpPost]
        public IActionResult Update_brand(Brand brand)
        {
          

            db.tbl_brand.Update(brand);
            db.SaveChanges();
            return RedirectToAction("Brand_details");
        }
        [HttpPost]
        public IActionResult Delete_brand(int brand_id) {
          var dlt=  db.tbl_brand.Find(brand_id);
            if(dlt != null) { 
            db.tbl_brand.Remove(dlt);
            db.SaveChanges();
            }
            return RedirectToAction("brand_details");
        }
        


        public IActionResult Brand_details(Brand brand)
        {
            var brand_data = db.tbl_brand.ToList();
            return View(brand_data);
        }


        public IActionResult Order_details()
        {
            var orderDetails = db.tbl_Order.ToList();
            if (orderDetails != null)
            {
                ViewBag.orders = orderDetails;
            }
            return View();
        }
        public IActionResult Add_customer()
        {
            return View();
        }
        public IActionResult Update_customer()
        {
            return View();
        }
        public IActionResult Customer_details()
        {
            var customer = "customer";
            var fetchdata = db.register.Where(p => p.User_role == customer).ToList();
            if (fetchdata.Any())
            {
                ViewBag.storedproduct = fetchdata;
            }

            return View();
           
        }
        public IActionResult ExportCategoryReport()
        {
            var categoryReport = db.order_Items
                .GroupBy(o => o.Product.Category.category_name)
                .Select(g => new CategoryReportModel
                {
                    Category = g.Key,
                    TotalProductsSold = g.Sum(o => o.Quantity),
                    TotalRevenue = g.Sum(o => o.TotalPrice)
                }).ToList();

            return new ExcelResult<CategoryReportModel>(categoryReport, "CategoryReport.xlsx", "Categories");
        }

        public IActionResult ExportBrandReport()
        {
            var brandReport = db.order_Items
                .GroupBy(o => o.Product.brand.brand_name)
                .Select(g => new BrandReportModel
                {
                    Brand = g.Key,
                    TotalProductsSold = g.Sum(o => o.Quantity),
                    TotalRevenue = g.Sum(o => o.TotalPrice)
                }).ToList();

            return new ExcelResult<BrandReportModel>(brandReport, "BrandReport.xlsx", "Brand");
        }
    }
}
