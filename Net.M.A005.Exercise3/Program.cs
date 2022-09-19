using System;

namespace Net.M.A005.Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Moi nhap vao 1 so:  ");
            }
            // check dữ liệu nhập vào có thể chuyển đổi sang dạng số nguyên được không , nếu không thì nhập lại
            while (!int.TryParse(Console.ReadLine(), out x));

            if (CheckPrimeNumber(x))
            {
                Console.WriteLine("So {0} co la so nguyen to", x);
            }
            else
            {
                Console.WriteLine("So {0} Khong la so nguyen to", x);
            }
        }
        // Hàm kiểm tra số nguyên tố
        static bool CheckPrimeNumber(int x)
        {
            if (x < 2)
            {
                return false;
            }
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
