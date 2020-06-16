using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
        {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }

            double value = x / y;

            return value;
        }

    

        static int CheckFileExtension(string fileName)
        {
            int studentPoints = 0;
            string value = fileName;


            if (value == null || value == "")
            {
                throw new ArgumentOutOfRangeException("Student did not send a File");
            }
            else if (value.EndsWith(".cs"))
            {
                studentPoints = 1;
            }

            return studentPoints;
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(9, 0));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }


            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> student in students)
            {

                try
                {
                    Console.WriteLine(student.Key + " : " + CheckFileExtension(student.Value));

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }


            }
        }


    }
}


