using OpticSolutions.Repositories.Entitys;
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

        DataRepositories repo = new DataRepositories();

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
        public ActionResult Status(Order ord)
        {
        

            return View(ord);
        }

        [HttpPost]
        public ActionResult ViewStatus(Order ord)
        {
            var data = repo.GetOrderById(ord);

            if (data!=null)
            {
                return View(data);
            }
            else
            {
                return RedirectToAction("Status", ord);
            }

           
        }

    }
}