using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Hello to your verry own interest calculator!\nplease enter your interest rate (%)");
                // turns the user number entered into a decimal
                decimal interestRatepercent = decimal.Parse
                    (Console.ReadLine());
                // converts to a interest rate percentage 
                decimal interestRate = interestRatepercent / 100;
                Console.WriteLine("Please enter your amount owed ($)\nTRUTHFULLY");
                // turns the user number entered into a decimal
                decimal amountOwed = decimal.Parse(Console.ReadLine());
                // input user values for them to view
                Console.WriteLine("Interest rate = " + interestRatepercent + "%");
                Console.WriteLine("Amount owed = " + amountOwed + "$");
                // calculates amount of interest
                decimal interest = interestRate * amountOwed;
                // creates a generic text to be used repeatedly
                string total = "Your amount owed is ";
                // my if statements
                if (interest > 10) Console.WriteLine(total + interest + "$");
                else if (amountOwed < 10) Console.WriteLine(total + amountOwed + "$");
                else if (10 > interest || 10 > amountOwed) Console.WriteLine(total + "10$");

                Console.ReadLine();
        }
    }
}
