using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Welcome4
{
    // Main method beings execution of C# application
    static void Main(string[] args)
    {
        int number1; // declare first number to add
        int number2; // declare second number to add
        int sum; // declare sum of number1 and number2

        Console.Write("Enter first integer: "); // prompt user 
        // read first number from user
        number1 = Convert.ToInt32(Console.ReadLine() );

        Console.Write("Enter second integer: "); //prompt user
        // read second number from user
        number2 = Convert.ToInt32(Console.ReadLine());

        sum = number1 * number2; // add numbers
        Console.WriteLine("Sum is {0} ", sum); //display sum


        Console.WriteLine("{0}\n{1}", "Hello World!", "From Logan Graham" );
        Console.WriteLine("{0}\t{1}", "Hello World!", "From Logan Graham");

        Console.ReadKey();

        /* 
         
        a. At the point static void Main(string[] args) in my application, is where it 
        executes.

        b. An integer type variable holds integer values from the minimum 
        value of -2,147,483,648 to +2,147,483,647 . 
        Float and double store approxmiations of real numbers in memory.

        c. An example of a method would be the GetName method, the goal of this method
        is to return the account name stored in a particular account
        object.

        d. To read the value of an instance variable, we create method called a
        Get accessor. To assign a value to a instance variable, we use a method 
        called a Set accessor.

        e.Objects are associated with instance variables while class variables are associated with class. 
        You can have an object of a class without a method of a class but you
        can't have a method of class without the declared object.
        Obects are also generally static.

        Yes, you can have multiple initializations of a class. By simply assigning 
        a variable to something is how you would initialize something, and for example 
        if you wanted multiple ones of a class you simply set the class to multiple variables.
         
         
         
         */


    } // end Main
} //end class Welcome4