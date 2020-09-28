using System;

namespace USRS2
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Введите 2 числа больше нуля:");
            Console.Write("Введите первое число - "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввдеите второе число - "); int b = Convert.ToInt32(Console.ReadLine());


            Console.Write("Оба числа больше нуля - ");
            bool x1 = (a > 0) & (b > 0); Console.WriteLine(x1);
            Console.Write("Оба числа меньше нуля - ");
            bool y1 = (a < 0) & (b < 0); Console.WriteLine(y1);
            Console.Write("Одно из чисел больше нуля и меньше 100 - ");
            bool x2 = ((a > 0) & (a < 100)) | ((b > 0) & (b < 100)); Console.WriteLine(x2);
            Console.Write("Одно из чисел меньше нуля и больше -100 - ");
            bool y2 = ((a < 0)&(a>-100)) | ((b < 0)&(b>-100)); Console.WriteLine(y2);
            Console.Write("Первое число больше второго - "); bool z = a > b; Console.WriteLine(z);

        }
    }
}