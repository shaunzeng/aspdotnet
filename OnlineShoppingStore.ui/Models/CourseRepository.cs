using OnlineShoppingStore.ui.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineShoppingStore.ui.Helpers;
using System.Threading.Tasks;

namespace OnlineShoppingStore.ui.Models
{
    public class CourseRepository
    {
        public List<Course> GetCourses()
        {

            List<Course> courses = new List<Course>{
                new Course("Angular in Depth", 1, true, false, 50, "Joe Doe"),
                new Course("Node in Depth", 2, true, false, 60,"Sam Smith"),
                new Course("ASP.NET in Depth", 3, true, false, 30, "Dave Dean"),
                new Course("MVC in Depth", 4, true, false, 35, "John Joe"),
                new Course("Algorithm", 5, true, false, 35, "John Joe"),
                new Course("Data Structure", 6, true, false, 35, "John Joe"),
            };

            return courses;
        }

        public List<Course> GetCourses(int number)
        {
            List<Course> result = GetCourses();
            List<Course> newList = new List<Course>();

            for(var i = 0; i < number; i++)
            {
                newList.Add(result[i]);
            }

            return newList;
        }

        public async Task<List<Course>> WebScrappingGetCourse()
        {

            List<Course> scrape = new List<Course>();
            WebScrapping web = new WebScrapping();
            scrape = await web.GetData();

            return scrape;
        }
    }
}