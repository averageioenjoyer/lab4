using System;

namespace lab4_task3_
{
    internal class Program
    {
        public static bool CheckNumber(int num)
        {
            int sum = 1;
            for (int i = 2; i < num / 2 + 1; i++) if (num % i == 0) sum += i;
            return (sum == num);
        }
        static void Main(string[] args)
        {
            int N = 0;
            Console.WriteLine("Введите число");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < N; i++)
                if (CheckNumber(i)) Console.WriteLine(i.ToString() + " является совершенным числом");
            Console.ReadKey();
        }
    }
}
