using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            2.	Identify and briefly describe 3 types of control structures that we can use to order the statements in our programs? 
            
            The sequence structure, a built in structure in which the computer executes the c# statements one oafter the other.
            selection structure, this includes if statements and the if else statement. Iteration structure, this includes the while, do while, for and foreach statement.
            




            Making this a comment so it doesn't actually loop an infinite times.


          
            bool keepLooping = true;
            while(keepLooping == true)
            {
                keepLooping = true;
                Console.WriteLine("True");
                
            }
          
            
             
             */



            int loopcontrol = 2;
            int counter = 0;
            while (counter < 65)
            {
                Console.WriteLine("[" + loopcontrol + "]");
                loopcontrol = loopcontrol * 2;
                counter++;
                if (loopcontrol==256)
                {
                    loopcontrol = 2;

                }
            }



            for (int k=49; k>0; k--)
            {
                Console.Write(k);
                if(k>1)
                {
                    Console.Write(",");
                }

            }
            Console.WriteLine();
            int p = 1;
            while(p <=21)
            {
                if ((p % 2) ==0)
                {
                    Console.Write(" ");
                }
                else if ((p % 2) !=0)
                {
                    Console.Write(p);
                }

                p++;
            }

            /*
             The code outputs is a single “ * ”.
            When there is a while statement instead of a do-while it does not output anything since the condition is false and
            the while statement does not execute even once if it is false unlike the do while, where it will execute atleast once even if it's false.
 
             
            
            We can use && to execute Booleans when both are true, and we can use || 
             to execute Booleans when only one is true, and lastly we can use ! to essentially make the logic backwards.
             Here I used an && with a combination of “!” before each variable.

             */
            bool icyRain = false;
            bool tornadoWarning=false;
            if (!icyRain && !tornadoWarning)
            {
                Console.WriteLine(System.Environment.NewLine+"Let's go outside!");

            }

            int o = 1;
            if(o !=6)
            {
                Console.WriteLine("123454321");
                o++;

                if (o != 6)
                {
                    Console.WriteLine(" " + "1234321");
                    o++;
                    if (o != 6)
                    {
                        Console.WriteLine("  " + "12321");
                        o++;

                        if (o != 6)
                        {
                            Console.WriteLine("   " + "121");
                            o++;

                            if (o != 6)
                            {
                                Console.WriteLine("    " + "1");
                                o++;

                            }
                        }
                    }
                }

            }


            Console.ReadKey();

        }
    }
}
