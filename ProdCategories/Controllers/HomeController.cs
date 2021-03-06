﻿using System;
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
            //***/ retrive product
            Product oneproduct = dbContext.Products.Include(q => q.Associations).ThenInclude(q => q.Category).FirstOrDefault(q =>q.ProductId == ProdId);

            //*** Get allCategories
            List<Category> allCategories = dbContext.Categories.ToList();

            //*** Get Only used categories
            // 1) Empty list
            List<Category> usedCategories = new List<Category>();
            // 2) Fill the list with all categories which this product assosiate with.
            foreach(Association association in oneproduct.Associations)
            {
                usedCategories.Add(association.Category);
            }

            //*** Get all unsued categories
            List<Category> NOTusedCategories = new List<Category>();
            
            foreach(Category category in allCategories)
            {
                if(!usedCategories.Contains(category))
                {
                    NOTusedCategories.Add(category);
                }
            }
            ViewBag.product = oneproduct;
            ViewBag.usedCategories = usedCategories;
            ViewBag.NOTusedCategories = NOTusedCategories;

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
            List<Category> _categories = dbContext.Categories.ToList();
            ViewBag.categories = _categories;
            return View("Categories");
        }
        // ---------------------------------------------------------------------
        // Post Adding category to db
        // --------------------------------------------------------------------- 
        [HttpPost("/createCategory")]
        public IActionResult createCategory(Category newCategory)
        {
            dbContext.Categories.Add(newCategory);
            dbContext.SaveChanges();
            return RedirectToAction("Categories");
        }
        // ---------------------------------------------------------------------
        // POST method ADDING CATEGORY TO PRODUCT
        // ---------------------------------------------------------------------
        [HttpPost("/catTOproduct")]
        public IActionResult catTOproduct(Association newass)
        {
            int r = newass.ProductId;
            dbContext.Associations.Add(newass);
            dbContext.SaveChanges();
            return Redirect($"/updateproduct/{r}");
        }
        // ---------------------------------------------------------------------
        // VIEW page to represent Categories
        // ---------------------------------------------------------------------
        [HttpGet("/updateCategory/{CategoryId}")]
        public IActionResult updateCategory(int CategoryId)
        {
            Category oneCategory = dbContext.Categories.Include(c=>c.Associations).ThenInclude(c=>c.Product).FirstOrDefault(c=>c.CategoryId == CategoryId);

            //*** Create list of ALL-PRODUCTS
            List<Product> allProducts = dbContext.Products.ToList();

            //*** Find all the product which are included in that category!!!
            List<Product> usedProducts = new List<Product>();
            foreach(var i in oneCategory.Associations)
            {
                usedProducts.Add(i.Product);
            }

            //*** Find unused product by this category.
            List<Product> notUsedProductbyThisCategory = new List<Product>();
            foreach(var i in allProducts)
            {
                if(!usedProducts.Contains(i))
                {
                    notUsedProductbyThisCategory.Add(i);
                }
            }


            ViewBag.oneCategory = oneCategory;
            ViewBag.usedProduct = usedProducts;
            ViewBag.NOTusedproducts = notUsedProductbyThisCategory;
            return View("UpdateCategory");
        }

        // ---------------------------------------------------------------------
        // POST method category >> assos >>> product{adding product to categ}
        // ---------------------------------------------------------------------
        [HttpPost("/addProdTOCat")]
        public IActionResult addProdTOCat(Association newass)
        {
            dbContext.Associations.Add(newass);
            dbContext.SaveChanges();
            int r = newass.CategoryId;
            return Redirect($"/updateCategory/{r}");
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
