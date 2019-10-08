using System;

namespace Calculator
{
    class Calculator
    {
        public int AddNums(int num1, int num2)
        {
            return num1 + num2;
        }
        public int SubtractNums(int num1, int num2)
        {
            return num1 - num2;
        }
        public int MultiplyNums(int num1, int num2)
        {
            return num1 * num2;
        }
        public int DivideNums(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Square(int num1)
        {
            return num1 * num1;
        }

        public double SquareRoot(int num1)
        {
            return Math.Sqrt(num1);
        }
        // public int SquareRoot(int num1)
        // {
        //     return 
        // }
    }
}