using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLabb3
{
    public class CalculateOption
    {
        public void Choice()
        {
            CalculationMethods cm = new CalculationMethods();
            double number1;
            double number2;

            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("Add: +");
            Console.WriteLine("Subtract: -");
            Console.WriteLine("Multiply: *");
            Console.WriteLine("Divide: /");
            Console.Write("Select an operator: ");
            string method = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Write a number: ");
            double.TryParse(Console.ReadLine(), out number1);
            Console.Write("Write another number: ");
            double.TryParse(Console.ReadLine(), out number2);

            switch (method)
            {
                case "+":
                    cm.Addition(number1, number2);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
                case "-":
                    cm.Subtraction(number1, number2);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
                case "*":
                    cm.Multiplication(number1, number2);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
                case "/":
                    cm.Division(number1, number2);
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error, can't divide by 0...");
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid input, try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
