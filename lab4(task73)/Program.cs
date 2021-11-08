using System;

namespace lab4_task73_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = Convert.ToInt32(Console.ReadLine());
            double final = Factorial(n);
            double temp = 0;
            for (double i = 1; i <= final; i++)
            {
                temp = temp +1/ Factorial(i);
            }
            Console.WriteLine(temp);
        }
        static double Factorial(double fack)
        {
            double n = fack;
            double factorial = 1;

            for (double i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}