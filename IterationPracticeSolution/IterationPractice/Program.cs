using System;

namespace IterationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //global variables
            String inputTemp;

            //int mySquare = 0;
            //int sumOfSquare = 0;

            //Console.Write("Enter a number to find out its sum of squares.\t");
            //inputTemp = Console.ReadLine();

            //xxx.TryParse takes the input string and attempts to converts the string
            //to the request numeric datatype
            //if the attempt is good then the value is placed in the out variable
            // and a true is returned
            //if the attempt fails, then a False is returned and No conversion is done

            //if (int.TryParse(inputTemp, out mySquare))
            //{
            //    if (mySquare > 0)
            //    {
            //        //one needs to do the interation at least once, seems a good candidate for post-loop
            //        int loopcounter = 1;
            //        string msg = "";
            //        do
            //        {
            //            msg = msg + $"{loopcounter}x{loopcounter}+";
            //            //sumOfSquare += loopcounter * loopcounter;
            //            sumOfSquare = sumOfSquare + loopcounter * loopcounter;
            //            //sumOfSquare += (int)Math.Pow(loopcounter, 2);
            //            loopcounter++;


            //        } while (loopcounter < mySquare);
            //        //using the string method called Subdstring() and Length()
            //        int msgLength = msg.Length;
            //        msg = msg.Substring(0, msgLength - 1);

            //        Console.WriteLine($"The sum of squares for {msg} = {sumOfSquare}");

            //        ////pre-test solution
            //        //int loopcounter = 1;
            //        //while (loopcounter<=4)
            //        //{
            //        //sumOfSquare += (int).Math.Pow(loopcounter, 2);
            //        //loopcounter++;
            //        //}

            //    }
            //    else
            //    {
            //        Console.WriteLine($"{mySquare} IServiceProvider invalid. Enter a positive greater than 0 number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid. Enter a number.");
            //}


            //Console.Write("Enter a number and display digits in reverse order.\t");
            //inputTemp = Console.ReadLine();
            //int aNumber;

            //if (int.TryParse(inputTemp, out aNumber))
            //{
            //    int aNumberLength = inputTemp.Length;

            //    //use the for(...) loop syntax
            //    //for(declare loopcounter; and condition; increment/decrement
            //    //{
            //    //  coding block
            //    //}
            //    for (int loopCounter = aNumberLength - 1; loopCounter >= 0; loopCounter--)
            //    {
            //        Console.WriteLine($"{inputTemp.Substring(loopCounter, 1)}");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine($"{inputTemp} is invalid. Enter a number.");
            //}

            //MoneyMaker
            //This program will accept a principal investment amount, a monthly interest rate,
            //the program will display a monthly investment report using the incoming data
            //this program will continue until the user enters an x to exit

            //procress: declare/assignment starting variables
            // request execution or exit from the user
            // on execution
            //  input investment values
            //  iternate monthly earnings and report
            //  on termination of investment period, display a summary

            //this example is one of using nested loops
            //menu loop will be a post-test loop
            //investment loop will be a pre-test loop using for()
            //output will demostrate formatting of values and columns

            decimal myPrincipal = 0.0m; //the m "types" this numeric as a decimal
            decimal myMonthlyInterestRate = 0.0m;
            Int32 myInvestmentTime = 0; //int32 is equilivant to int 

            string menuChoice = "";
            do
            {
                Console.WriteLine("Welcome to CPSC Investments:\n\n");
                Console.WriteLine("a) investment:");
                Console.WriteLine("x) to exit\n:");
                Console.Write("Enter your menu choice");
                menuChoice = Console.ReadLine();

                    switch(menuChoice.ToUpper())
                    {
                    case "A":
                        {
                            //for this example, I will assume valid data is entered
                            Console.Write("\nEnter your principal investment amount:\t");
                            inputTemp = Console.ReadLine();
                            myPrincipal = decimal.Parse(inputTemp);

                            Console.Write("\nEnter your investment monthly rate (3%):\t");
                            inputTemp = Console.ReadLine();
                            myMonthlyInterestRate = decimal.Parse(inputTemp);

                            Console.Write("\nEnter your investment period in months:\t");
                            inputTemp = Console.ReadLine();
                            myInvestmentTime = Int16.Parse(inputTemp);

                            //use a loop for a fix amount of interations
                            //best candidate would be a pre-test loop
                            // a) While with a counter
                            // b) for (...) loop
                            for(int monthCounter = 1; monthCounter <= myInvestmentTime; monthCounter++)
                            {
                                //the {0} is referred to as a placeholder
                                //the string.Format(format pattern, value for the pattern)
                                //pattern is currency and the 0 indicates a placeholder for the value
                                //in the .Format method

                                Console.Write("\nOpening: {0}\t", string.Format("{0:c}", myPrincipal));

                                //.ToString("pattern")
                                //# indicates a digit position and is optional, printed if Not Zero (0)
                                //0 indicates a digit position and is required, zeros are printed
                                Console.Write("Interest Paid: {0}\t",
                                    (myPrincipal * myMonthlyInterestRate).ToString("$###,##0.00"));

                                myPrincipal += myPrincipal * myMonthlyInterestRate;

                                //{variable, xcolumnwidth: pattern}
                                //variable is myPrincipal
                                // x column width is 15 spaces, positive value is right align, negative
                                //  value is left align
                                Console.Write($"Closing: {myPrincipal,15:0:c}\n");
                                //Console.Write($Closing:{myPrincipal, 15:0:$###,##0.00}\n"}
                            }
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("\nThank you. Good-Bye.\n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYou entry for the menu choice is invalid. Try again.\n");
                            break;
                        }

                    }


            } while (menuChoice.ToLower() != "x");
            
            string msg = "Good luck on your future investment.";
            
            for(int i=0; i < msg.Length;i++)
            {
                Console.Write("*");
            }
                Console.WriteLine("\nmsg\n");

        }
    }
}
