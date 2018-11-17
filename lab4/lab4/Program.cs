using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The four basic elements of the counter-controlled reptition includes: control variable, 
            The beginning value of the control variable, the increment for the variable or the decrement for the variable,
            and the condition for the loop that tells it if it should continue.

            The while loop is a repetition statement that can continuously process instructions until the condition is mt.
            For loop is also a reptition statement that can execute information continuously, the main difference is that 
            for loop can be used when there is a known number of iterations and while creates it as it executes.
            while for
            
            While this may not be the best example, and does have flaws it just helps show that the 
            do while can at times be more useful becuase it doesn't check the loop condition until it 
            executes the body, this also shows that the normal while loop has to execute the condition before it 
            runs the body, and in this example it would not work.
            Do {
            int value;
            Console.Write("Enter a value a positive integer");
            value = Console.ReadLine();
            } while (value>=0);
            
            While (value>=0) {
             int value;
            Console.Write("Enter a value a positive integer");
            value = Console.ReadLine();
            }
    
            */

           
            for (int i =1; i < 101; i++)
            {
                Console.WriteLine(i);
                if ((i % 2) == 0)
                {
                    Console.WriteLine("Variable is even");
                        

                }
                else
                {
                    Console.WriteLine("Variable is odd");
                }
            }

            
            Console.WriteLine("Please enter a temperature");
            int temperature = Convert.ToInt32(Console.ReadLine());
            if (temperature < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (temperature<20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if(temperature < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temperature < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if(temperature < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temperature < 90)
            {
                Console.WriteLine("Fish");
            }
            else 
            {
                Console.WriteLine("Bug");
            }

            int l = 9;
            while (l < 20)
            {
                l++;
                Console.WriteLine(l);
            }


            for (int m = 0; m < 101; m++)
            {
                Console.WriteLine(m);
                Console.WriteLine("********");
            }


            Console.ReadKey();

        }
    }
}
