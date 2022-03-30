using System;

namespace Lesson_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            myDeligate mDl;
            Calculator calculator = new Calculator();
            mDl = calculator.GetCalcMethod("+");
            mDl += calculator.GetCalcMethod("-");
            mDl += calculator.GetCalcMethod("/");
            double x = mDl.Invoke(8, 4);
            Console.WriteLine("*****************************");

            //Ex2
            myDligate2 mDl2;
            Calculator2 calculator2 = new Calculator2();
            mDl2 = calculator2.Add;
            mDl2 += calculator2.Subtract;
            mDl2 += calculator2.Div;
            calculator2.CalcAnyThing(10, 5, mDl2);
        }
    }
}
