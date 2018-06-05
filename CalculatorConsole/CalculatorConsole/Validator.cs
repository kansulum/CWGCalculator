using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
   public class Validator
    {
        public bool Validate(string equation)
        {
            var regexItem = new System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]*$");
            if (regexItem.IsMatch(equation))
            {
                return true;
            }
            else
               return false;
        }
    }
}
