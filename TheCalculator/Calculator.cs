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
        public static string FixExpression(string expression)
        {

            if (Regex.IsMatch(expression, @"(\d+)([\+\-\*\/]\d+)*") == false)
			{
				return @"输入错误";
			}
            return Convert.ToString(new SimpleExpressionEvaluator.ExpressionEvaluator().Evaluate(expression));
        }
        
    }
} 
