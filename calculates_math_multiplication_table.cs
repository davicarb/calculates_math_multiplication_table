using System;
using System.Linq.Expressions;
class loopForDentroDeDoWhile
{
    static void Main()
    {

        string option;

        do
        {


            // This is one of my first aplications on C# using the for loop. I know nowadays AI is much used for simple things like this, and,
            // yes, AI could do this in a blink of an eye, even better than this. buttt... this is one of the moments when i stop in front of Visual
            // Studio and try to build something with my own brain, so when AI produces code to me, I know exactly what's going on in every single
            // line of code. So this is kind of an "workout", let's put it this way. Hope you like it!

            Console.WriteLine("Welcome!\n");
            Console.WriteLine("Insert a number to know its multiplication table (1 to 10): ");

            int constantNumber = int.Parse(Console.ReadLine());

            while (constantNumber > 10 || constantNumber < 0)
            {
                Console.WriteLine("Incorrect input. Try again:");
                constantNumber = int.Parse(Console.ReadLine());
            }

            int variableNumber;

            for (variableNumber = 0; variableNumber <= 10; variableNumber++)
            {
                Console.WriteLine($"{constantNumber} x {variableNumber} = {constantNumber * variableNumber}");
            }
             

            Console.WriteLine("Would you like to repeat the program?");
            option = Console.ReadLine();

        } while (option == "Y" || option == "y");
    }
}
