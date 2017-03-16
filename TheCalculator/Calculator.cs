using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TheCalculator
{
    public class Calculator
    {
        string expression;
        public void NewExpression()
        {
            expression = Console.ReadLine();
        }
        public decimal FixExpression()
        {

            if (Regex.IsMatch(expression, @"(\d+)([\+\-\*\/]\d+)*") == false)
                Console.WriteLine("invalid expression");
           return  new SimpleExpressionEvaluator.ExpressionEvaluator().Evaluate(expression);
        }
    }
} 
