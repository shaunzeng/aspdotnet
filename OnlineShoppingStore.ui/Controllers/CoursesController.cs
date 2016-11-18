using OnlineShoppingStore.ui.Entities;
using OnlineShoppingStore.ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OnlineShoppingStore.ui.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public async Task<ActionResult> Index()
        {
            CourseRepository courses = new CourseRepository();
            ViewBag.courses = await courses.WebScrappingGetCourse();

            return View();
        }
    }
}