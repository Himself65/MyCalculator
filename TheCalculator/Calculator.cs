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
        public void NewExpression(string exp)
        {
            expression = exp;
            return;
        }
        public string FixExpression()
        {

            if (Regex.IsMatch(this.expression, @"(\d+)([\+\-\*\/]\d+)*") == false)
            {
                Console.WriteLine("error");
            }
           return  Convert.ToString(new SimpleExpressionEvaluator.ExpressionEvaluator().Evaluate(this.expression));
        }
        public string FixExpression(string expression)
        {

            if (Regex.IsMatch(expression, @"(\d+)([\+\-\*\/]\d+)*") == false)
            {
                Console.WriteLine("error");
            }
            return Convert.ToString(new SimpleExpressionEvaluator.ExpressionEvaluator().Evaluate(expression));
        }
        
    }
} 
