using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write an expression with two numbers and an operator with space in-between, for example, 4 + 2");
                string expression;
                string[] array;
                string[] array1;
                expression = Console.ReadLine();

                string vars = Variables(expression);
                Console.WriteLine(vars);

                // iterate over the variables
                char[] varss = SplitVariables(Variables(expression));
                int[] variablesValues = new int[varss.Length];

                for (int i = 0;i < varss.Length; i++)
                {
                    Console.WriteLine("Please enter the value for {0}", varss[i]);
                    variablesValues[i] = Convert.ToInt32( Console.ReadLine());
                }

                array = expression.Split();
                array1 = Calculation(array);
                Console.WriteLine("Press ENTER to write a new expression.");
                Console.ReadLine();
                Console.Clear();
            }

        } 
             

        static string Variables (string equation)
        {           
            string variables = new String(equation.Where(Char.IsLetter).ToArray());            
            return variables;
        }

        static char[] SplitVariables(string equation)
        {
            return equation.ToCharArray();
        }
        
        static string[] Calculation(string[] arr)
        {
            double numLeft = 0.0;
            double numRight = 0.0;
            string sign = "";
            double result = 0.0;
            int index = 1;

            while (true)
            {
                numLeft = Convert.ToDouble(arr[0]);
                sign = Convert.ToString(arr[index]);
                numRight = Convert.ToDouble(arr[index + 1]);
                index = index + 2;
                if (sign == "+")
                {
                    Console.Clear();
                    Console.WriteLine();
                    result = result + numLeft;
                }
                else if (sign == "-")
                {
                    Console.Clear();
                    result = result + numLeft;
                    numLeft = 0 - numRight;
                }
                
                else
                {
                    break;
                }
                result = result + numLeft;
                Console.WriteLine("Answer: {0}", result);
                return arr;
            }
            return arr;
        }
    }
}
