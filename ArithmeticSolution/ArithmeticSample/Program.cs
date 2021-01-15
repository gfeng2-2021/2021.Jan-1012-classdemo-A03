using System;

namespace ArithmeticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //the special character \n adds extra blank line
            //it is called the next line character
            Console.WriteLine("Arithmetic Sample\n");

            //declare a variable of datatype double
            //syntax; datatype variablename assignment operator literal numeric value;
            //         double    Total             =                 0.0;
            double Total = 0.0;
            double Cost = 15.23;
            double Tax = 0.81;

            //arithematic assignment operation
            //syntax; receiving variable assignment opeartor binary arithmetic expression
            //              Total               =                   Cost + Tax;
            //action: the expression will be executed and the result will be placed into
            //          the receving variable
            Total = Cost + Tax;

            Console.WriteLine($"The result of {Cost} + {Tax} is {Total}");

            //An alternate way of outputting your variable will be to use string
            //  concatenation.
            //String concatenation uses the operator +
            Console.WriteLine("The result of " + Cost + " + " + Tax + " is " + Total);

            //An alternate way is to use placeholders
            //placeholders start at 0 and increment by 1
            //placeholder value are in a list after the string
            //ORDER IS IMPORTANT

            Console.WriteLine("The result of {0} + {1} is {2}",Cost,Tax,Total);

        }
    }
}
