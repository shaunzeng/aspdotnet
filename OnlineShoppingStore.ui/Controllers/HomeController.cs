using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using OnlineShoppingStore.ui.Models;

namespace OnlineShoppingStore.ui.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var courses = new CourseRepository();
            ViewBag.courses = courses.GetCourses(3);

            var quizzes = new QuizRepository();
            ViewBag.quizzes = quizzes.GetQuizzes(3);

            return View();
        }
    }
}