using System;

namespace inputOutputMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implement a temp converter from
             * Celsius to Fahrenheit
             * 
             * Jan 2021
             */

            //input: Celsius temperature
            //      string inputTemp
            //      double theCelsiusTemperature

            //output: Fahrenheit temperature
            //      double theFahrenheitTemperature

            //expression (calculate): (ct * (9.0/5.0)) + 32
            //check with ct = 0 expect ft = 32
            //check with ct = 100 expect ft = 212
            //check with ct = -40 expect ft = -40

            //prompt for a celsius temperature
            // .Write() keeps your cursor on the same line
            Console.Write("Enter a Celsius temperature: ");

            //How does the program pull in the entry from the suer
            //to obtain the key stockes that the user types (input)
            //  .ReadLine()
            //important!!!
            //  data comes into the program as a string
            //  DOES NOT matter if you enter a number, it is treated as
            //  a string.

            //declare the variable:     datatype variablename;
            string inputTemp;
            //assignment statement:     expression on the right is placed
            //                          into the variable on the left
            //expression (action):      read the user input
            inputTemp = Console.ReadLine();

            //you could do both statements on one line
            //string inputTemp = Console.Readline();

            //currently the celsius value is a string
            //the value needs to be converted to a number to be
            //  used in a math calculation
            //convert the data to a different datatype
            //to do this; you will use technique called parsing
            //  syntax: datatypeTo.Parse(string value)

            //WARNING: I am assuming the user will enter valid data
            //          if the user does not enter a number this program
            //              will abort on the execution of this line
            double theCelsiusTemperature = double.Parse(inputTemp);

            //calculation using the conversion expression
            double theFahrenheitTemperature =
                        (theCelsiusTemperature * (9.0/5.0) + 32);

            //output
            //  .WriteLine() which automatically goes to the next line.
            Console.WriteLine($"The Celsius temperature of {theCelsiusTemperature} is " +
                $"{theFahrenheitTemperature} in Fahrenheit.");
        }
    }
}
