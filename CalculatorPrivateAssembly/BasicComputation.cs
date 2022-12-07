using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static float Add(float num1, float num2)
        {
            float result = num1 + num2;
            return result; 
        }

        public static float Substract(float num1, float num2)
        {
            float result = num1 - num2;
            return result;

        }

        public static float Multiply(float num1, float num2)
        {
            float result = num1 * num2;
            return result;

        }

        public static float Divide(float num1, float num2)
        {
            float result = num1 / num2;
            return result;

        }

    }
}
