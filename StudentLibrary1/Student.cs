using System;
using System.Collections.Generic;
using System.Text;

namespace StudentLibrary1
{
    internal class Student
    {

        // private fields
        private int id;
        private string name;
        private int age;
        private int studentCount = 0;

        // Public Properties
        public int Id
        { 
        get { return id; }
            
        }

        public string Name
        { 
        get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set {  age = value; }
        }

        public int StudentCount
        {
            get { return studentCount; }
        }
    }
}
