using OpticSolutionsClient.Repositories;
using OpticSolutionsClient.Repositories.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpticSolutionsClient.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Services()
        {

            return View();
        }

        public ActionResult Contact()
        {
         

            return View();
        }
        public ActionResult Blog()
        {
        
            return View();
        }

     
    }
}