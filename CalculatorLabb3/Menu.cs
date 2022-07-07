using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLabb3
{
    public class Menu
    {
        CalculateOption cal = new CalculateOption();
        CalculationMethods cam = new CalculationMethods();
        public void CalcMenu()
        {
            bool menu = true;
            while (menu)
            {
                int Option;
                Console.WriteLine("Welcome to the Calculator 101! Choose one of the following...");
                Console.WriteLine("[1] Calculate");
                Console.WriteLine("[2] See your previous calculations");
                Console.WriteLine("[3] Exit");
                Int32.TryParse(Console.ReadLine(), out Option);
                switch (Option)
                {
                    case 1:
                        cal.Choice();
                        break;
                    case 2:
                        cam.PrintResult();
                        break;
                    case 3:
                        Console.WriteLine("Goodbye for now...");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again...");
                        break;
                }
            }
        }
    }
}
