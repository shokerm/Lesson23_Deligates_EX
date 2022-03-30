using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_23
{
    internal class Calculator
    {
        public double Div(double num1, double num2)
        {
            Console.WriteLine(num1 / num2);
            return num1 / num2;
        }

        public double Subtract(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
            return num1 - num2;
        }
        public double Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }

        public myDeligate GetCalcMethod(string opr)
        {
            switch (opr)
            {
                case "+":
                    return Add;
                case "-":
                    return Subtract;
                case "/":
                    return Div;
                default:
                    return null;
            }
        }
    }

    internal class Calculator2
    {
        public void Div(double num1, double num2)
        {
            Console.WriteLine(num1 / num2);
        }

        public void Subtract(double num1, double num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }


        public void CalcAnyThing(double num1, double num2, myDligate2 mdl2)
        {
            mdl2.Invoke(num1, num2);
        }
    }
}
