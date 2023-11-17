using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20231115_Schilling_Euro
{
    internal class GeneralFunction
    {
        private string ChangePointToComma(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.')
                {
                    result += ',';
                }
                else
                {
                    result += input[i];
                }
            }
            return result;
        }
    }
}
