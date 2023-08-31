using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int marks_maths, marks_physics, marks_chemistry, marks_cs;
            Console.WriteLine ("Enter your maths marks");
            marks_maths = Convert.ToInt32(Console.ReadLine()); //Enter and read the maths marks.

            Console.WriteLine ("Enter your physics marks");
            marks_physics = Convert.ToInt32(Console.ReadLine()); //Enter and read the physics marks.

            Console.WriteLine ("Enter your chemistry marks");
            marks_chemistry = Convert.ToInt32(Console.ReadLine()); //Enter and read the chemistry marks.

            Console.WriteLine ("Enter your computer science marks");
            marks_cs = Convert.ToInt32(Console.ReadLine()); //Enter and read the computer science marks.

            int percentage;
            percentage = (marks_chemistry + marks_maths + marks_chemistry + marks_cs)/4; //Calcuate the percentage mark.
            Console.WriteLine("Your percentage is" + percentage);

            switch (percentage) //
            {
                case var s when (percentage >= 80):
                    Console.WriteLine("Excellent! Your grade is A");
                    break;
                case var s when (percentage >= 70 && percentage < 80):
                    Console.WriteLine("Good! Your grade is B");
                    break;
                case var s when (percentage >= 60 && percentage < 70):
                    Console.WriteLine("Satisfactory. Your grade is C");
                    break;
                case var s when (percentage >= 50 && percentage < 60):
                    Console.WriteLine("‘Pass. Your grade is D’");
                    break;
                case var s when (percentage < 50):
                    Console.WriteLine("Fail. Your grade is F");
                    break;
            }
            Console.ReadKey(); //Read the result based on the grade.
        }
    }
}
