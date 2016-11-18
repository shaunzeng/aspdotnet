using OnlineShoppingStore.ui.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.ui.Models
{
    public class QuizRepository
    {
        public List<Quiz> GetQuizzes()
        {

            List<Quiz> courses = new List<Quiz>{
                new Quiz("Angular test", 1,"this is a test on angular basics", true, 90, "Angular in Depth","Excellent"),
                new Quiz("Node test", 2,"this is a test on node basics", true, 40, "Node in Depth", "Failed"),
                new Quiz("ASP.NET test", 1,"this is a test on asp.net basics", false, 0, "APS.NET in Depth", null),
                new Quiz("MVC test", 1,"this is a test on MVC basics", true, 25, "MVC Basics", "Failed"),
                new Quiz("Algorithm", 1,"this is a test on algorithm", true, 75, "Algorithm","Good"),
                new Quiz("Data Structure test", 1,"this is a test on data structure", true, 70, "Data Strcuture", "Good"),
            };

            return courses;
        }

        public List<Quiz> GetQuizzes(int number)
        {
            List<Quiz> result = GetQuizzes();
            List<Quiz> newList = new List<Quiz>();

            for (var i = 0; i < number; i++)
            {
                newList.Add(result[i]);
            }

            return newList;
        }

    }
}