﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
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
            return View("index");
        }
        // ---------------------------------------------------------------------
        // Registrating to db
        // ---------------------------------------------------------------------
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
                int user_id = user.UserId;
                HttpContext.Session.SetInt32("user_id",user_id);
                return RedirectToAction("Dashbord");
            }
            return View("Index");
        }
        // ---------------------------------------------------------------------
        // Login Page
        // ---------------------------------------------------------------------
            [HttpGet("Login")]
            public IActionResult Login()
            {
                return View("Login");
            }
        // ---------------------------------------------------------------------
        // Login TO success or BELT EXAM would be this page !
        // ---------------------------------------------------------------------
        [HttpPost("logToSuccess")]
        public IActionResult LoginSuccess(LoginUser userSubmision)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmision.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("Email","Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(userSubmision,userInDb.Password,userSubmision.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("Password","Invalid Email/Password");
                    return View("Login");
                }
                //--------------------- Creating session after all those checks -------------------
                int user_id = userInDb.UserId;
                HttpContext.Session.SetInt32("user_id",user_id);
                return RedirectToAction("Dashbord");
            }
            return View("Login");
        }

        // ---------------------------------------------------------------------
        // CLEAR SESSION
        // ---------------------------------------------------------------------
            [HttpGet("/clear")]
            public IActionResult clearSession()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login");
            }
        // ---------------------------------------------------------------------
        // Success PAGE potential belt-exam page
        // ---------------------------------------------------------------------
        // ---------------------------------------------------------------------
        // Wedding Dashbord
        // ---------------------------------------------------------------------

            [HttpGet("/Dashbord")]
            public IActionResult Dashbord()
            {
                if(HttpContext.Session.GetInt32("user_id") == null)
                {
                    return RedirectToAction("Login");
                }
                    return View("Dashbord");
            }
        // ---------------------------------------------------------------------
        // Adding Wedding input VIEW PAGE
        // ---------------------------------------------------------------------
        [HttpGet("/addWedding")]
        public IActionResult AddWedding()
        {
            if(HttpContext.Session.GetInt32("user_id")== null)
            {
                return RedirectToAction("Login");
            }
            @ViewBag.user_id = (int)HttpContext.Session.GetInt32("user_id");
            return View("AddWedding");
        }
        // ---------------------------------------------------------------------
        // POST FORM CREATE WEDDING
        // ---------------------------------------------------------------------
        [HttpPost("/createWedding")]
        public IActionResult CreateWedding(Wedding newwed)
        {
            Console.WriteLine(newwed.Groom);
            Console.WriteLine(newwed.Bride);
            Console.WriteLine(newwed.UserId);
            Console.WriteLine(newwed.Date);
            if(HttpContext.Session.GetInt32("user_id") == null)
            {
                return RedirectToAction("Login");
            }
            if(newwed.Date < DateTime.Now)
            {
                ModelState.AddModelError("Date","Wedding must be in the future");
                return View("AddWedding");
            }
            else if(ModelState.IsValid)
            {
                dbContext.Add(newwed);
                dbContext.SaveChanges();
                return RedirectToAction("Dashbord");
            }
            else
            {
                ViewBag.errors = ModelState.Values;
                return View("AddWedding");
            }
        }

        // ---------------------------------------------------------------------
        // VIEW wedINFORMATION
        // ---------------------------------------------------------------------
        [HttpGet("/WeddingINFO")]
        public IActionResult WeddingINFO()
        {
            if(HttpContext.Session.GetInt32("user_id")== null)
            {
                ModelState.AddModelError("Email","Don't be sneaky");
                ModelState.AddModelError("Password","I know what you did last summer :) !!!");
                return View("Login");
            }

            return View("WeddingINFO");
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