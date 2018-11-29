using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RSSFeedReader.Controllers
{
    public class RSSFeedController : Controller
    {
        // GET: RSSFeed
        public ActionResult Index()
        {
            return View();
        }
    }
}