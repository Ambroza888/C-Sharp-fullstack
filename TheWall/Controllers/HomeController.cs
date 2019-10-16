using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace TheWall.Controllers
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
        // Log in TO success or BELT EXAM would be this page !
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
                return RedirectToAction("Success");
            }
            return View("Login");
        }
        [HttpGet("clear")]
        public IActionResult clearSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        // ---------------------------------------------------------------------
        // Success PAGE potential belt-exam page
        // ---------------------------------------------------------------------
        // ---------------------------------------------------------------------
        // -=================||||||||||||||||||||||||========================-
        // ---------------------------------------------------------------------

        [HttpGet("Success")]
        public IActionResult Success()
        {
            if(HttpContext.Session.GetInt32("user_id") == null)
            {
                ModelState.AddModelError("Email", "I know what are you trying to do but is not going to work i asked Stas for it !");
                return View("Login");
            }
            List<Message> allmessages = dbContext.Messages.OrderByDescending(w =>w.CreatedAt).Include(w=>w.User).ThenInclude(w=>w.Comments).ToList();

            ViewBag.allmessages = allmessages;
            ViewBag.user_id = HttpContext.Session.GetInt32("user_id");
                return View("Success");
        }

        // ---------------------------------------------------------------------
        // Post Rout to create Comment
        // ---------------------------------------------------------------------
        [HttpPost("/PostMessage")]
        public IActionResult PostMessage(Message newmess)
        {
            if(HttpContext.Session.GetInt32("user_id")== null)
            {
                return RedirectToAction("Login");
            }
            if(ModelState.IsValid)
            {
            dbContext.Add(newmess);
            dbContext.SaveChanges();
            return RedirectToAction("Success");
            }
            ///*** Don't forget ViewBAG! !! sCUM BAG !
            List<Message> allmessages = dbContext.Messages.OrderByDescending(w =>w.CreatedAt).Include(w=>w.User).ThenInclude(w=>w.Comments).ToList();
            ViewBag.allmessages = allmessages;
            return View("Success");
        }


        // ---------------------------------------------------------------------
        // Post rout to POST COMMENT
        // ---------------------------------------------------------------------
        [HttpPost("/PostComment")]
        public IActionResult PostComment(Comment newcoment)
        {
            if(HttpContext.Session.GetInt32("user_id")==null)
            {
                return RedirectToAction("Login");
            }
            if(ModelState.IsValid)
            {
                dbContext.Add(newcoment);
                dbContext.SaveChanges();
                return RedirectToAction("Success");
            }
            List<Message> allmessages = dbContext.Messages.OrderByDescending(w =>w.CreatedAt).Include(w=>w.User).ThenInclude(w=>w.Comments).ToList();
            ViewBag.allmessages = allmessages;
            ViewBag.errors = ModelState.Values;
            return View("Success");

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
