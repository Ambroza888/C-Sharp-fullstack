using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // ---------------------------------------------------------------------
        // ROUTES
        // ---------------------------------------------------------------------
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> allDishes = dbContext.Dishes.ToList();
            return View("Index",allDishes);
        }
        // ---------------------------------------------------------------------
        // 
        // ---------------------------------------------------------------------

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View("Create");
        }
        // ---------------------------------------------------------------------
        // Create redirected
        // ---------------------------------------------------------------------
        [HttpPost("addDish")]
        public IActionResult addDish(Dish newDISH)
        { 
            if(ModelState.IsValid)
            {
                dbContext.Add(newDISH);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else{ return View("Create");}
        }
        // ---------------------------------------------------------------------
        // About page
        // ---------------------------------------------------------------------
        [HttpGet("/about/{DishId}")]
        public IActionResult About(int DishId)
        {
            Dish one = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == DishId);

            return View("About",one);
        }
        // ---------------------------------------------------------------------
        // Delete dish
        // ---------------------------------------------------------------------
        [HttpGet("Delete/{DishId}")]
        public IActionResult Delete(int DishId)
        {
            Dish remove = dbContext.Dishes.SingleOrDefault(v => v.DishId == DishId);
            dbContext.Dishes.Remove(remove);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        // ---------------------------------------------------------------------
        // Edit dish
        // ---------------------------------------------------------------------
        [HttpGet("Edit/{DishId}")]
        public IActionResult Edit(int DishId)
        {
            Dish one = dbContext.Dishes.SingleOrDefault( v => v.DishId == DishId);
            return View(one);
        }
        // ---------------------------------------------------------------------
        // Edited
        // ---------------------------------------------------------------------

        [HttpPost("Edit/{DishId}")]
        public IActionResult Edit(Dish newOne,int DishId)
        {
            Dish old = dbContext.Dishes.FirstOrDefault(v => v.DishId == DishId);
            old.Name = newOne.Name;
            old.Chef = newOne.Chef;
            old.Description = newOne.Description;
            old.Calories = newOne.Calories;
            old.Tastiness = newOne.Tastiness;
            old.Updated_at = DateTime.Now;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }







        // ---------------------------------------------------------------------
        // ERORR
        // ---------------------------------------------------------------------

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
