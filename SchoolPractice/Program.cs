using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student annalyssa = new Student("Annalyssa");
            Console.WriteLine("The Student class works! " + annalyssa.StudentId + " is a student!");

            Student teehoos = new Student("Teehoos");
            Console.WriteLine("The Student class works! " + teehoos.StudentId + " is a student!");
        }
    }
}