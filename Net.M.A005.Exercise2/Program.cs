using System;

namespace Net.M.A005.Exercise2
{
    class Program
    {

        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Moi nhap so dong cua day so Fibonacci:  ");
            }
            while (!int.TryParse(Console.ReadLine(), out x));
            Console.WriteLine("Day so Fibonacci:  ");
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(PrintFibonacci(i));
            }
        }
        static int PrintFibonacci(int n)
        {
            int x0 = 0;
            int x1 = 1;
            int xn = 1;
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    x0 = x1;
                    x1 = xn;
                    xn = x0 + x1;
                }
            }
            return xn;
        }

    }
}
