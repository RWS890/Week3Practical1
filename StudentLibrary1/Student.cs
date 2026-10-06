using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Reflection.Metadata.Ecma335;
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
        public Student()
        {
            Name = "John Doe";
            Age = 16;
            id = studentCount++;
            
        }

        public Student(string Name, int Age)
        { 
        this.name = Name;
        this.age = Age;
        id = studentCount++;
        }

        public void Display()
        {
            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"Student's name: {Name}");
            Console.WriteLine($"Student's age: {Age}");

        }

        public static void GetOlder()
        {
            
            //return ++age;
        }
        
    }
   
}
