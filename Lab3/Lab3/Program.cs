using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*             
            An if statement allows an app to make a decision based on the value of a condition, true or false and then runs the code inside the statement once.
            The while repitition statement continuously runs the code within as long as the expression is true.
            Both make an decision based on either the correct answer or the false answer.
             */

            int speedLimit = 35;
            int speed = 42;
            
            if (speed>speedLimit)
            {
                Console.WriteLine("SLOW NOW");
                Console.WriteLine();
            }
           
            bool isTrue = true;
            if (isTrue == false)
            {
                Console.WriteLine("It is False!");

            }
            else
            {
                Console.WriteLine("It is True!");
            }

            Console.WriteLine();

            Console.WriteLine("Input Degree in Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            if (fahrenheit <= 40 )
            {
                Console.WriteLine("It is cold");
            }
            if (fahrenheit >= 90)
            {
                Console.WriteLine("It is hot");
            }

            double celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine(fahrenheit  +  " Fahrenheit Converted to celsius = "+celsius +" celsius");

            Console.WriteLine();
            int n = 0;
            while (n < 11)
            {
                Console.WriteLine(n);
                n++;
               
            }
            Console.WriteLine();


            int m = 60;
            while (m > 19)
            {
                Console.WriteLine(m);
                m-= 5;
            }

            Console.WriteLine();

            int j = 10;
            while (j < 21)
            {
                Console.WriteLine(j);
                j += 2;
            }





            Console.ReadKey();


        }
    }
}
