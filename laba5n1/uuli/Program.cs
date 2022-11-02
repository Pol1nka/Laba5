using System;

namespace Laboratorka5
{
    public static class Program
    {
        public static void Main()
        {
            double previousNum = double.NaN;
            while (true)
            {
                Console.WriteLine("Введите число: ");

                string input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }    
                    
                bool success = int.TryParse(input, out int Num);

                if (success)
                {
                    Console.WriteLine((char)Num);
                    previousNum = Num;
                    continue;
                }
                double doubleNumber = double.Parse(input);

                if (Math.Abs(doubleNumber - previousNum) < 1e-9)
                {
                    Console.WriteLine("Введенное число и предыдущее одинаковы!");
                    break;
                }

                previousNum = doubleNumber;
            }
        }
    }
}