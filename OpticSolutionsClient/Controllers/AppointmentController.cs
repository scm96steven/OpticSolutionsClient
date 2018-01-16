using CaptchaMvc.HtmlHelpers;
using OpticSolutionsClient.Repositories;
using OpticSolutionsClient.Repositories.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpticSolutionsClient.Controllers
{
    public class AppointmentController : Controller
    {
        DataRepositories repo = new DataRepositories();
  
        public ActionResult CrearCita()
        {
            Appointment ap = new Appointment();
            return View(ap);
        }

        [HttpPost]
        public ActionResult CrearCita(Appointment ap)
        {
            string start = ap.StartDateStr + " " + ap.StartHourStr;
            ap.StartDate = DateTime.Parse(start);

            ap.NumberOfAppointments = repo.CheckAppointments(ap);
            if (!ModelState.IsValid || ap.NumberOfAppointments > 0)
            {

                return View(ap);
            }

            else
            {

                return RedirectToAction("Confirm", ap);
            }

        }

        public ActionResult Confirm(Appointment ap)
        {


            ap.Date = DateTime.Now;
            if (ap.StartDate==null)
            {
                string start = ap.StartDateStr + " " + ap.StartHourStr;
                ap.StartDate = DateTime.Parse(start);
            }
   
            var userRepo = new DataRepositories();
            var user = repo.GetUserInfoById(ap.DoctorUsername);
            ap.DoctorFullname = user.FullName();


            return View(ap);
        }

        [HttpPost]
        public ActionResult CreateAppointment(Appointment ap)
        {
            if (this.IsCaptchaValid("Captcha is not valid"))
            {
                //ap.StartDate = DateTime.Parse(ap.StartDateStr);
                repo.CreateAppointment(ap);

                return RedirectToAction("Index", "Home", null);
            }

            return RedirectToAction("Confirm", "Appointment", ap);
        }

        public ActionResult PendingAppointment(Appointment ap)
        {
           
            ap.Date = new DateTime(2001, 1, 1);
            var data = repo.GetAllAppointments(ap);
            return View(data);
        }


        public JsonResult GetAppointments(Appointment ap)
        {
            var list = repo.GetAppointments(ap);

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDoctors()
        {

            var list = repo.GetDoctors();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}