using SpecFlowCalculator;
using System;
using System.Collections.Generic;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public List<int> ListNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;

        }
        public int AddMultipleNumbers()
        {
            int result = 0;
            if (ListNumber.Count > 0)
            {
                foreach (int n in ListNumber)
                    result += n;
            }
            return result;
        }
        public int Multiply()
        {

            return FirstNumber * SecondNumber;
        }
        public int MultiplyMultipleNumbers()
        {
            int result = 0;
            if (ListNumber.Count > 0)
            {
                foreach (int n in ListNumber)
                    result += result * n;
            }
            return result;
        }
        public int Divide()
        {
            if (SecondNumber == 0)
                return 0;
            else
                return Convert.ToInt32(FirstNumber / SecondNumber);
        
            //return FirstNumber / SecondNumber;
        }
        public int Minus()
        {
            return FirstNumber - SecondNumber;
        }

        /*
        internal static double DoOperation(double cleanNum1, double cleanNum2, string op)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }*/

    }
}
