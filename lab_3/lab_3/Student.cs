using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Department
        {
            set { department = value; }
            get { return department; }
        }

        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
       public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Department : " + department);
            Console.WriteLine("CGPA : " + cgpa);

        }
    }
}
