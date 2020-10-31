using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }

        public string CourseCode
        {
            set { courseCode = value; }
            get { return courseCode; }
        }
         public int CourseCredit
        {
            set { courseCredit = value; }
            get { return courseCredit; }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course name :" + courseName);
            Console.WriteLine("Course code :" + courseCode);
            Console.WriteLine("Course credit :" + courseCredit);
        }
       
    }
}
