using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.ui.Entities
{
    public class Quiz
    {
        public string QuizName { get; set; }
        public int QuizId { get; set; }
        public string QuizDescription { get; set; }
        public bool isTaken { get; set; }
        public int QuizResult { get; set; }
        public string forCourse;
        public string QuizLevel;
        public Quiz(string name,int id, string desc, bool taken, int result, string course, string level)
        {
            QuizName = name;
            QuizId = id;
            QuizDescription = desc;
            isTaken = taken;
            QuizResult = result;
            forCourse = course;
            QuizLevel = level;
        }
    }
}