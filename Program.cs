using System;
using System.Collections.Generic;
namespace MaxMinMark
{
    class Program
    {
        static void Main(string[] args)
        {
            // infinite loop
            for (; ; )
            {
                // Lists are ever expanding containers whichstore info
                List<double> marks = new List<double>();
                // WriteLine prints to console screen
                Console.WriteLine("Do you wish to use my MaxMin mark finder?");
                // ToUpper() turns characters to upper case
                string userValue = Console.ReadLine().ToUpper();
                // if the condition is meet perform task
                if (userValue == "N")
                {
                  // This code line end the program
                  Environment.Exit(0);
                }
                // if above is not meet do the following
                else
                {
                    // a loop
                    for (int j = 0; j < 1; j++)
                    {
                        // WriteLine prints to console screen
                        Console.WriteLine("How many marks will you enter?");
                        // bool is a true or false statement
                        // .TryPase checks if the value is a certain variable type and puts out the value
                        bool josh1 = int.TryParse(Console.ReadLine(), out int amount);
                        // if false clear screen and sets loop counter back one
                        if (josh1 == false)
                        {
                            Console.Clear();
                            j --;
                        }
                        else
                        {
                            // loop the amount of the variable amount 
                            for (int variable = 0; variable < amount; variable++)
                            {
                                
                                for (int switzerland = 0; switzerland < 1; switzerland++)
                                {
                                    // implicit concatenation and adding 1 to the variable variable
                                    Console.WriteLine("Mark #{0}", variable + 1);
                                    // bool is a true or false statement
                                    // .TryPase checks if the value is a certain variable type and puts out the value
                                    bool joshTest = double.TryParse(Console.ReadLine(), out double josh);
                                    // if false clear screen and sets loop counter back one
                                    if (joshTest == false)
                                    {
                                        Console.Clear();
                                        switzerland --;
                                    }
                                    // if entered marks exceed parameters, error message and count back one
                                    else if (josh > 100 || josh < 0.01)
                                    {
                                    Console.WriteLine("numbers entered execceed percentage amount\nTry again");
                                    switzerland --;
                                    }
                                    // else add mark to list
                                    else
                                    {
                                    marks.Add(josh);
                                    }
                                }

                            }
                            // setting values
                            double max = 0.00;
                            double min = 100;
                            // converting to array
                            marks.ToArray();
                            // foreach mark detrmine if it is the biggest or lowest mark
                            foreach (double josh in marks)
                            {
                                if (josh > max)
                                {
                                max = josh;
                                }
                                else if (josh < min)
                                {
                                min = josh;
                                }
                            }
                            // subbtract largest value by smallest to find range
                            double range = max - min;
                            // clears console
                            Console.Clear();
                            // inpolating data, writing stuff in console
                            Console.WriteLine($"The max mark is {max}\nThe min mark is {min}\nThe range is {range}\nPress ENTER to continue");
                            // allows user to read response
                            Console.ReadLine();
                            // clears console
                            Console.Clear();
                        }
                    }
                    
                    
                }
            }
            
        }
    }
}
