using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shefDish.Models;
using Microsoft.EntityFrameworkCore;

namespace shefDish.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        // ---------------------------------------------------------------------
        // Index
        // ---------------------------------------------------------------------
        [HttpGet("")]
        public IActionResult Index()
        {
            List <Chef> AllChefs = dbContext.Chefs.Include(c=> c.CreatedDishes).ToList();
            return View("Index",AllChefs);
        }
        // ---------------------------------------------------------------------
        // Form to add NEW CHEF
        // ---------------------------------------------------------------------
        [HttpGet("new")]
        public IActionResult New()
        {

            return View("new");
        }
        // ---------------------------------------------------------------------
        // Adding Chef POST rout
        // ---------------------------------------------------------------------
        [HttpPost("add")]
        public IActionResult Add(Chef newChef)
        {
            // -Checking if the chef is more than 18years old-
            DateTime date = Convert.ToDateTime(newChef.DOB);
            int age = (DateTime.Now.Year - date.Year);
            if (date.Date > DateTime.Today.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                ModelState.AddModelError("DOB", " The Chef need to be atleast 18 years old");
                return View("new");
            }
            // model Check-----------------------
            if(ModelState.IsValid)
            {   
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("new");
            }
        }
        // ---------------------------------------------------------------------
        // Show Dishes VIEW
        // ---------------------------------------------------------------------
        [HttpGet("/dishes")]
        public IActionResult Dishes()
        {
            List <Dish> _dishes = dbContext.Dishes.Include(c=>c.Chef).ToList();

            return View("Dishes",_dishes);
        }
        // ---------------------------------------------------------------------
        // Addin Dish View Rout
        // ---------------------------------------------------------------------
        [HttpGet("/addDish")]
        public IActionResult addDish()
        {
            List<Chef> all_chefs = dbContext.Chefs.ToList();
            ViewBag.Chefs = all_chefs;
            return View("addDish");
        }

        // ---------------------------------------------------------------------
        // Post ADDING DISH !
        // ---------------------------------------------------------------------
        [HttpPost("/CreateDish")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {
                List<Chef> all_chefs = dbContext.Chefs.ToList();
                ViewBag.Chefs = all_chefs;
                return View("addDish");
            }
        }





















        // ---------------------------------------------------------------------
        // Error message
        // ---------------------------------------------------------------------
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
