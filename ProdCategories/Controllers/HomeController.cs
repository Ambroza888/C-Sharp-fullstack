using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProdCategories.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace ProdCategories.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // ---------------------------------------------------------------------
        // Routes
        // ---------------------------------------------------------------------
        [HttpGet("")]
        public IActionResult Product()
        {
            List<Product> _products = dbContext.Products.ToList();
            ViewBag.products = _products;
            return View("Product");
        }
        // ---------------------------------------------------------------------
        // View Update category page
        // ---------------------------------------------------------------------
        [HttpGet("/updateproduct/{ProdId}")]
        public IActionResult Updateproduct(int ProdId)
        {
            Product oneproduct = dbContext.Products.Include(c=>c.PRODtoCATEG).ThenInclude(c=>c.Catergory).FirstOrDefault(c=>c.ProductId == ProdId);
            List<Catergory> _categories = dbContext.Catergories.ToList();

            ViewBag.categories = _categories;
            ViewBag.pruduct = oneproduct;

            return View("Updateproduct");
        }
        // ---------------------------------------------------------------------
        // Post Adding Product
        // ---------------------------------------------------------------------
        [HttpPost("createProduct")]
        public IActionResult createProduct(Product newProduct)
        {
            dbContext.Products.Add(newProduct);
            dbContext.SaveChanges();
            return RedirectToAction("Product");
        }
        // ---------------------------------------------------------------------
        // View page for Categories
        // ---------------------------------------------------------------------
        [HttpGet("/Categories")]
        public IActionResult Categories()
        {
            List<Catergory> _categories = dbContext.Catergories.ToList();
            ViewBag.categories = _categories;
            return View("Categories");
        }
        // ---------------------------------------------------------------------
        // Post Adding category to db
        // --------------------------------------------------------------------- 
        [HttpPost("/createCategory")]
        public IActionResult createCategory(Catergory newCategory)
        {
            dbContext.Catergories.Add(newCategory);
            dbContext.SaveChanges();
            return RedirectToAction("Categories");
        }
        // ---------------------------------------------------------------------
        // POST method ADDING CATEGORY TO PRODUCT
        // ---------------------------------------------------------------------
        [HttpPost("/catTOproduct/{productId}")]
        public IActionResult catTOproduct(int productId)
        {
            return RedirectToAction("Product");
        }




























        // ---------------------------------------------------------------------
        // Error
        // ---------------------------------------------------------------------

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
