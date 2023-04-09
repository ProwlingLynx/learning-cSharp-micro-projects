using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // what is a calculator?
            /**
             * a calculator prompts for an input and spits out an output.
             * actions: prompt for an input: input 1, operator, and input 2
             * edge cases? incorrect input and incorrect operator
             * 
             */
            Console.WriteLine("Welcome to the calculator!");
            Console.WriteLine("Please enter a number:");
            double inputNumber1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an operator: +, -, /, *.");
            String inputOperator = Console.ReadLine();
            Console.WriteLine("Please enter another input:");
            double inputNumber2 = double.Parse(Console.ReadLine());

            double outputValue = 0;
            if (inputOperator.Equals("+"))
            {
                outputValue = inputNumber1 + inputNumber2;
            }
            else if (inputOperator.Equals("-"))
            {
                outputValue = inputNumber1 - inputNumber2;
            }
            else if (inputOperator.Equals("/"))
            {
                outputValue = inputNumber1 / inputNumber2;
            }
            else if (inputOperator.Equals("*"))
            {
                outputValue = inputNumber1 * inputNumber2;
            }

            Console.WriteLine("Your total is: {0}!", outputValue);
        }
    }
}
