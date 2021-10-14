using EscuelaDeConexionn.Models;
using EscuelaDeConexionn.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EscuelaDeConexionn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

           //  Courses courses = new Courses();
           CoursesRepository coursesRepository = new CoursesRepository();

           //  courses.Title = "programacion aplicada 1";
           // courses.Credits = 10;
           //coursesRepository.Create(courses );

            var listOfData = coursesRepository.ListDataCourses();

            return View(listOfData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}