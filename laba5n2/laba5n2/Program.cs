using System;

namespace Laboratorka5
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Введите число: ");

            string number = Console.ReadLine();
            bool flag = true;
            int sum = 0;
            int numCount = number.Length;
            for (int i = 0; i < numCount; i++)
            {
                char element = (char)number[i];
                if (!(element >= 48 && element <= 57))
                {
                    Console.WriteLine("Данное число не целое!");
                    flag = false;
                    break;
                }
                sum = sum + element - '0';
            }

            if (flag)
            {
                Console.WriteLine($"Сумма цифр данного числа: {sum}");
            }
        }
    }
}
