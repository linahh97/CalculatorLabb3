using System;
using System.Collections.Generic;

namespace CalculatorLabb3
{
    public class CalculationMethods
    {
        public double result { get; set; }
        public string res { get; set; }
        public CalculationMethods()
        {
        }
        public CalculationMethods(double _result)
        {
            result = _result;
        }

        List<string> ListOfCalculations = new List<string>();
        public double Addition(double num1, double num2)
        {
            result = num1 + num2;
            Console.WriteLine($"Result: {num1} + {num2} = " + result);
            res = $"{num1} + {num2} = {result}";
            ListOfCalculations.Add(res);
            return result;
        }

        public double Subtraction(double num1, double num2)
        {
            result = num1 - num2;
            Console.WriteLine($"Result: {num1} - {num2} = {result}");
            res = $"{num1} - {num2} = {result}";
            ListOfCalculations.Add(res);
            return result;
        }

        public double Multiplication(double num1, double num2)
        {
            result = num1 * num2;
            Console.WriteLine($"Result: {num1} * {num2} = {result}");
            res = $"{num1} * {num2} = {result}";
            ListOfCalculations.Add(res);
            return result;
        }

        public double Division(double num1, double num2)
        {
            result = num1 / num2;
            Console.WriteLine($"Result: {num1} / {num2} = {result}");
            res = $"{num1} / {num2} = {result}";
            ListOfCalculations.Add(res);
            return result;
        }

        public string PrintResult()
        {
            Console.WriteLine("Previous calculations:");
            foreach (var item in ListOfCalculations)
            {
                Console.WriteLine($"{item}");
            }
            if (ListOfCalculations.Count == 0)
            {
                Console.WriteLine("No");
            }
            Console.ReadLine();
            Console.Clear();
            return "not valid";
        }
    }
}
