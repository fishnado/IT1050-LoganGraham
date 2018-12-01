using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Fill in the blanks in the following statement:
A one-dimensional array p contains four elements.  The array access expressions 
to access each of the elements in p are __p[0]_____, ___ p[1]____,
___ p[2]____ and ___ p[3]___.

             */


            string[] Months = new string[12];
            Months[0] = "1st  Jaunary";
            Months[1] = "2nd  February";
            Months[2] = "3rd  March";
            Months[3] = "4th  April";
            Months[4] = "5th  May";
            Months[5] = "6th  June";
            Months[6] = "7th  july";
            Months[7] = "8th  August";
            Months[8] = "9th  September";
            Months[9] = "10th October";
            Months[10] ="11th November";
            Months[11] ="12th December";

            
            for (int b = 0; b < Months.Length; b++)
             {
                Console.WriteLine(Months[b]);
             }



        

      
            string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
           
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }






            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int k=0; k < randomNumber.Length; k++)
            {
                randomNumber[k] = random.Next(0, 100);

            }

            foreach (int k in randomNumber)
            {
                Console.WriteLine(k.ToString());

            }






            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }






            string[] namez = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int z = 0;
            foreach (string name in namez)
            {
                Console.WriteLine("{0,2}. {1}", z, namez[z]);
                z++;

            }





            string[] named = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            
            foreach (string name in named)
            {
                Console.WriteLine(name);
            }

                                 
           

            

       










        }
    }
}
