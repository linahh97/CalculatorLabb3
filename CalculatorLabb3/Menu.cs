using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLabb3
{
    public class Menu
    {
        CalculationMethods cam = new CalculationMethods();
        public void CalcMenu()
        {
            Console.WriteLine("Welcome to the Calculator 101! Choose one of the following...");
            Console.WriteLine("[1] Calculate");
            Console.WriteLine("[2] See your previous calculations");
            Console.WriteLine("[3] Exit");
            int Option;
            Int32.TryParse(Console.ReadLine(), out Option);
            bool menu = true;
            while (menu)
            {
                switch (Option)
                {
                    case 1:
                        Choice();
                        break;
                    case 2:
                        cam.PrintResult();
                        CalcMenu();
                        break;
                    case 3:
                        Console.WriteLine("Goodbye for now...");
                        menu = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again...");
                        break;
                }
            }
        }
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
                    CalcMenu();
                    break;
                case "-":
                    cm.Subtraction(number1, number2);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    CalcMenu();
                    break;
                case "*":
                    cm.Multiplication(number1, number2);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    CalcMenu();
                    break;
                case "/":
                    cm.Division(number1, number2);
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    CalcMenu();
                    break;
                default:
                    Console.WriteLine("Invalid input, try again...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
