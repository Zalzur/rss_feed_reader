using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RSSFeedReader.Models;

namespace RSSFeedReader.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            User userModel = new User();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(User userModel)
        {
            using (UserModels user = new UserModels())
            {
                user.Users.Add(userModel);
                user.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration succsessful!";
            return View("AddOrEdit", new User());
        }
    }
}