using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RSSFeedReader.Models;

namespace RSSFeedReader.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Registration(int id=0)
        {
            User userModel = new User();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult Registration(User userModel)
        {
            using (UserModels user = new UserModels())
            {
                if (user.Users.Any( x => x.Username == userModel.Username))
                {
                    ViewBag.DuplicateMessage = "Username already exist!";
                    return View("Registration", userModel);
                }
                user.Users.Add(userModel);
                user.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration succsessful!";
            return View("Registration", new User());
        }
    }
}