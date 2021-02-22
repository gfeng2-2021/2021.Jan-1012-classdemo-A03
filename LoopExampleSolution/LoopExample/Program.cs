using System;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // string inputTemp;
            // int aNumber;

            //Console.Write("Enter a number: \t");
            // inputTemp = Console.ReadLine();
            // aNumber = int.Parse(inputTemp);
            // int loopExecutions = 0;


            // //pre-test loop
            // while (aNumber!=0)
            // {
            //     //all code within this coding block 
            //     // belongs to the loop
            //     //a fast way of adding 1 to a counter
            //     loopExecutions++;
            //     Console.WriteLine($"You entered the number {aNumber}");
            //     Console.Write("Enter a number: \t");
            //     inputTemp = Console.ReadLine();
            //     aNumber = int.Parse(inputTemp);
            // }//end of while

            // //next statement is the 1st executable statement after the loop
            // Console.WriteLine($"The loop has finished, you executed te loop {loopExecutions}");

            // //post-test loop
            // do
            // {
            //     //all code within this coding block 
            //     // belongs to the loop
            //     //a fast way of adding 1 to a counter
            //     loopExecutions++;
            //     Console.WriteLine($"You entered the number {aNumber}");
            //     Console.Write("Enter a number: \t");
            //     inputTemp = Console.ReadLine();
            //     aNumber = int.Parse(inputTemp);
            // } while (aNumber != 0);
            // //end of while

            //     //next statement is the 1st executable statement after the loop
            //     Console.WriteLine($"The loop has finished, you executed te loop {loopExecutions}");

            //requirements
            //data: counter for marks entered (int)
            //totaling variable (int)
            //final average variable (int or double or round)
            // what will be the terminating value
            // could one use a character (string) to terminate
            // calculate and display the number of students and average

            //string inputTemp;
            //int sumOfMarks = 0;
            //int countOfStudents = 0;
            //int inputNumber = 0;

            //Console.Write("Enter the student mark or X to exit:\t");
            //inputTemp = Console.ReadLine();

            ////pre - test
            //while (inputTemp.ToUpper() != "X")
            //{
            //    if (int.TryParse(inputTemp, out inputNumber))
            //    {
            //        if (int.Parse(inputTemp) <= 100 && int.Parse(inputTemp) >= 0)
            //        {
            //            sumOfMarks += int.Parse(inputTemp);
            //            countOfStudents++;
            //            Console.Write("\nEnter the student mark or X to exit:\t");
            //            inputTemp = Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Your number is outside of the acceptable range of 0 to 100");
            //            Console.Write("\nEnter the student mark or X to exit:\t");
            //            inputTemp = Console.ReadLine();
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Your entered value is not a number");
            //        Console.Write("\nEnter the student mark or X to exit:\t");
            //        inputTemp = Console.ReadLine();

            //    }
            //}
            //if (countOfStudents == 0)
            //{
            //    Console.WriteLine("\nYou did not enter any student marks.");
            //}
            //else
            //{
            //    Console.WriteLine($"\nThere are {countOfStudents} students. Their average mark is {Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}");
            //}

            //post-test
            //do
            //{
            //    Console.Write("\nEnter the student mark or X to exit:\t");
            //    inputTemp = Console.ReadLine();
            //    if (inputTemp.ToUpper() != "X")
            //    {
            //        sumOfMarks += int.Parse(inputTemp);
            //        countOfStudents++;
            //    }
            //    inputTemp = Console.ReadLine();
            //}
            //while (inputTemp.ToUpper() != "X");

            //string tempInput;
            //int sumOfNumber = 0;
            //int countOfNumber = 0;
            //int inputNumber = 0;
            //int mysquare = 0;

            //Console.Write("Enter number:\t");
            //tempInput = Console.ReadLine();
            //mysquare = int.Parse(tempInput);

            //while (countOfNumber<mysquare)

            //{
            //    if (int.TryParse(tempInput, out inputNumber))
            //    { 


            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Input.");
            //        Console.Write("Enter number:\t");
            //        tempInput = Console.ReadLine();
            //    }
            //}

            //bacterial loop example
            //string inputTemp;
            //decimal finalPopulation = 0.0m;
            //decimal initialPopulation = 0.0m;
            //const decimal MaxDays = 10; //PascalCase is also used for const MaxDays

            //will need the Math libarary for e (2.71828)
            //Console.Write("Enter your initial bacterial population:\t");
            //inputTemp = Console.ReadLine();
            //if(decimal.TryParse(inputTemp, out initialPopulation))
            //{
            //    //we have a known number of interations
            //    for (int i=1;i<=MaxDays)
            //}
            //else
            //{
            //    Console.WriteLine($"Invalid input{inputTemp}; not a valid numeric");
            //}

            //string inputTemp;
            //double tempC;
            //double tempF;
            //Console.Write("Please enter a temperature in celsius:\t\n");
            //inputTemp = Console.ReadLine();
            //if (double.TryParse(inputTemp, out tempC))
            //{
            //    tempF = tempC * 9 / 5 + 32;
            //    Console.WriteLine($"The temp in Fahrenheit is {tempF}\n");
            //    if (tempF < 50)
            //    { Console.WriteLine("It is too cold!"); }
            //    else if (tempF <= 100)
            //    { Console.WriteLine("It is just right!"); }
            //    else
            //    { Console.WriteLine("It is too hot!"); }
            //}

            //int experience = 3;
            //double bonus = 5.0;
            //double a;
            //string d;e;ff;gg;hh;

            //a = bonus * experience;

            //string ab = "d";
            //if (ab == "a" || ab == "b" || ab == "c")
            //    { }
            //else
            //{ Console.WriteLine("d"); }
            string inputTemp;
            double tempC;
            double tempF;
            Console.Write("Please enter a temperature in celsius:\t\n");
            inputTemp = Console.ReadLine();
            if (double.TryParse(inputTemp, out tempC))
            {
                tempF = (tempC * 9.0 / 5.0) + 32;
                Console.WriteLine($"The temp in Fahrenheit is {tempF}\n");
                if (tempF < 50)
                { Console.WriteLine("It is too cold!"); }
                else if (tempF <= 100)
                { Console.WriteLine("It is just right!"); }
                else
                { Console.WriteLine("It is too hot!"); }
            }


        }

    }
}