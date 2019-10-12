using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login_Registration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Login_Registration.Controllers
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
                //-- after answer all the conditions hash pass and add user
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user,user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                int user_id = user.UserId;
                HttpContext.Session.SetInt32("user_id",user_id);
                return RedirectToAction("Success");
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
        // Login redirect to success
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
                // Creating session after all those checks -----------
                int user_id = userInDb.UserId;
                HttpContext.Session.SetInt32("user_id",user_id);
                return RedirectToAction("Success");
            }
            return View("Login");
        }
        // ---------------------------------------------------------------------
        // CLEAR SESSION
        // ---------------------------------------------------------------------
        [HttpGet("clear")]
        public IActionResult clearSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        // ---------------------------------------------------------------------
        // Success PAGE potential belt-exam page
        // ---------------------------------------------------------------------

        [HttpGet("Success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("user_id") == null)
            {
                return RedirectToAction("Login");
            }
            int? tempid = HttpContext.Session.GetInt32("user_id");
            User OneUser = dbContext.Users.FirstOrDefault(u=>u.UserId == (int)tempid);

            List<Transaction> _transactions = dbContext.Transactions.OrderByDescending(c=>c.UpdatedAt).Where(c=>c.UserId == tempid).ToList();
            decimal balance = 0;
            foreach(var i in _transactions)
            {
                balance += i.Amount;
            }
            ViewBag.OneUser = OneUser;
            ViewBag._transactions = _transactions;
            ViewBag.balance = (decimal)balance;
            HttpContext.Session.SetInt32("balance",(int)balance);
                return View("Success");
        }
        // ---------------------------------------------------------------------
        // Post Deposit/Witdraw
        // ---------------------------------------------------------------------
        [HttpPost("/depoWith")]
        public IActionResult depoWith(Transaction newTrans)
        {
            if(HttpContext.Session.GetInt32("user_id")==null)
            {
                return RedirectToAction("login");
            }
            else
            {
                dbContext.Transactions.Add(newTrans);
                int? temp = HttpContext.Session.GetInt32("balance");
                decimal check = newTrans.Amount;
                if(((int)temp + (int)check) > 0)
                {
                    dbContext.SaveChanges();
                    return RedirectToAction("Success");
                }
                else
                {
                    // if the balance is < 0 i have to pull all that code from top because of the custom massage which i want to show on the page ModelState.add need the VIEWBAGS !
                    int? tempid = HttpContext.Session.GetInt32("user_id");
                    User OneUser = dbContext.Users.FirstOrDefault(u=>u.UserId == (int)tempid);

                    List<Transaction> _transactions = dbContext.Transactions.OrderByDescending(c=>c.UpdatedAt).Where(c=>c.UserId == tempid).ToList();
                    decimal balance = 0;
                    foreach(var i in _transactions)
                    {
                        balance += i.Amount;
                    }
                    ViewBag.OneUser = OneUser;
                    ViewBag._transactions = _transactions;
                    ViewBag.balance = (decimal)balance;
                    ModelState.AddModelError("Amount",$"Not enought Balance on you're bank account to take of {newTrans.Amount}$");
                        return View("Success");
                }

                }
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
