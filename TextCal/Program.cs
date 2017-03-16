using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalcTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("input a expression:");
            var expression = Console.ReadLine();

            if (Regex.IsMatch(expression, @"(\d+)([\+\-\*\/]\d+)*") == false)
                Console.WriteLine("invalid expression");


            Console.WriteLine("{0}={1}", expression, new SimpleExpressionEvaluator.ExpressionEvaluator().Evaluate(expression));
        }
    }
}