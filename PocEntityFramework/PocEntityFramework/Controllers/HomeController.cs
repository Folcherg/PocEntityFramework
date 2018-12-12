using PocEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PocEntityFramework.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        /*public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }*/
        
        MoviesDBModel _db;

        public HomeController()
        {
            _db = new MoviesDBModel();
        }


        public ActionResult Index()
        {
            ViewData.Model = _db.Movie.ToList();
            return View();
        }
    }    
}
