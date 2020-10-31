using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Nayamet Ullah";
            s1.Id = "19-39295-1";
            s1.Department = "CSE";
            s1.Cgpa = 3.90f;
            s1.ShowInfo();
            Console.WriteLine();
            Triangle t1 = new Triangle();
            t1.X = 10;
            t1.Y = 10;
            t1.Z = 8;
            t1.ShowInfo();
            t1.TestTriangle();
            Console.WriteLine();
            Account a1 = new Account();
            a1.AccName = "Dishan Ahmed";
            a1.AcId = "1111";
            a1.Balance = 10000;
            a1.Deposite(2000);
            Console.WriteLine();
            a1.Withdraw(5000);
            Console.WriteLine();
            Course c1 = new Course();
            c1.CourseName = "OOP2";
            c1.CourseCode = "C101";
            c1.CourseCredit = 3;
            c1.ShowCourseInfo();

        }
    }
}
