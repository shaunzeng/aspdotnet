using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore.ui.Entities
{
    public class Course
    {
        public string CourseName { get; set; }
        public int CourseId { get; set; }
        public bool isStarted;
        public bool isFinished;
        public int? CourseCompletion;
        public string CourseInstructor;
        public Course(string name, 
                      int id,
                      bool started,
                      bool finished,
                      int completion,
                      string instructor)
        {
            CourseName = name;
            CourseId = id;
            isStarted = started;
            isFinished = finished;
            CourseCompletion = completion;
            CourseInstructor = instructor; 
        }
    }
}