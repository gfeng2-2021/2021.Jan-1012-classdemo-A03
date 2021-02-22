using System;

namespace FileOL
{
    class Program
    {   //main() is a method
        //special method
        //entry point into your program execution
        static void Main(string[] args)
        {
            /*
             * process
             * this program will demo mothods, menu looping and various styles of File I/O
             * create a post-loop (do/while) to handle the menu
             * the menu will have 3 options, one for each type of file I/O style
             * methods will be used to obtain the file name to be read for this program
             * the methods will have no incoming parameter, will return a string datatype
             * the reading and display of the file will be placed in a seperate method
             * the method will have a string incoming parameter, will not return anything (void datatype)
             * the method demon error handling using try/catch/final
             */
            string inputTemp;
            do
            {

                
                Console.WriteLine("File I/O options: \t");
                Console.WriteLine("a) hard-coded file name.");
                Console.WriteLine("b) using windows environmental (desktop, documents, download) path file name.");
                Console.WriteLine("c) using openfile dialog to obtain file name.");
                Console.WriteLine("x) exit\n.");
                inputTemp = Console.ReadLine();
                switch(inputTemp.ToUpper())
                {
                    case "A":
                        {
                            break;
                        }
                    case "B":
                        {
                            break;
                        }
                    case "C":
                        {
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank you");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"{inputTemp} is not valid.");
                            break;
                        }
                }

            } while (inputTemp.ToUpper() != "X");


        }
        /* methods
        * reduce code redundancy 
        * break up code into smaller managable pieces (modularization)
        * 
        * where do methods go?
        *   methods go into your program class
        *   
        *   syntax for a method
        *   accesstype returnDatatype methodName ([list of parameters])
        *   {
        *       coding block
        *   }
        *   accessType?
        *   this is dependant on what is the Main access type or if the 
        *   class is NOT the entry point to your entire application,
        *   could be public, private, internal, protected....
        *   
        *   return datatype
        *   methods have been called by many names
        *   methods have been called subroutines, functions, methods
        *   subroutines and functions are different in that subroutines returns no data to the calling statement
        *   where as functions will return data to the calling statement
        *   the return datatype must be a valid language datatype
        *   the return datatype in C# that returns nothing is the keyword void
        *   
        *   methodName
        *   this is what the method is called
        *   the method name is usually unique
        *   the method names that are not unique are paired with their list of parameters to create a method signature
        *   the method signature MUST be unique. This is referred to as overloaded methods.
        *   
        *   [list of parameters] (optional)
        *   
        *   
        * what is a parameter?
        * consider the paramter a variable within your method that has 
        * already been declared and can be used as other variable
        * datatype parametername
        * 
        * what is a list of parameters?
        * datatype parametername, datatype prametername, .....
        */
        static string HardCodedFileName()
        {
            //setup a path name to the folder on your machine that contains
            // the file to be read
            string Folder_Pathname = @"E:\Github\CPSC-1012\FileProcessing\";

            //concatenate a file name to the pathname
            string Full_Path_Filename;
            Full_Path_Filename = Folder_Pathname + @"OneColumn.txt";

            //because the method indicates a returned datatype of string (anthing but void), the method
            //requires a return xxxx; statement

            return Full_Path_Filename;
        }
    }
}
