using System;

namespace Net.M.A005_.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.Write("Nhap so nguyen x = ");
            }
            while (!int.TryParse(Console.ReadLine(), out x));
            ConvertToBinary(x);
        }
        static void ConvertToBinary(int x)
        {
            string Result = string.Empty;
            for (int i = 0; x > 0; i++)
            {
                Result = x % 2 + Result;
                x = x / 2;
            }
            Console.WriteLine("So nhi phan sau khi chuyen doi la: " + Result);
            Console.ReadKey();
        }
    }
}
