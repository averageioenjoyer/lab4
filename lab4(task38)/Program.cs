using System;

namespace lab4_task38_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n = Convert.ToInt32(Console.ReadLine());
            float final=(2*n+1)*(2*n+1);
            float temp =0;
            for (float i = 3; i <= final; i = i + 2){
                temp = temp + (1 / (i*i));
            }
            Console.WriteLine(temp);
        }
    }
}
