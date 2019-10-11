using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login_Registration.Models;
using Microsoft.AspNetCore.Identity;

namespace Login_Registration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View("index");
        }
        [HttpPost("/Register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email","Email already in use!");
                    return View("Index");
                }
                else if(dbContext.Users.Any(u => u.FirstName == user.FirstName))
                {
                    ModelState.AddModelError("FirstName","First Name is already in use!");
                    return View("Index");
                }
                else if(dbContext.Users.Any(u => u.LastName == user.LastName))
                {
                    ModelState.AddModelError("LastName","Last Name is already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user,user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                return RedirectToAction("Login");
            }
            return View("Index");
        }
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View("Login");
        }

























        // ---------------------------------------------------------------------
        // ERRORRR
        // ---------------------------------------------------------------------

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
