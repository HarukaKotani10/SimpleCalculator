using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    public class HelperCalculation
    {
        public static float GetFinalResult(float first, float second, char finalOperation)
        {
            float finalResult = 0;

            switch (finalOperation)
            {
                case '+':
                    finalResult = first + second;
                    break;
                case '-':
                    finalResult = first - second;
                    break;
                case '*':
                    finalResult = first * second;
                    break;
                case '/':
                    finalResult = first / second;
                    break;
                default:
                    finalResult = second;
                    break;
            }

            return finalResult;
        }
    }
}
