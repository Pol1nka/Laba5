using System;
using System.Linq;

namespace Laboratorka5
{
    public class Program
    {
        public static double Factorial(double number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        public static void Main()
        {
            string[] data = Console.ReadLine().Split();
            double[] result = new double[data.Length];
            int CountArray = data.Length;

            for (int i = 0; i < CountArray; i++)
            {
                bool isInt = int.TryParse(data[i], out int elements);
                if (elements > 0 && isInt)
                {
                    result[i] = Factorial(elements);
                }

                else if (elements < 0 && isInt)
                {
                    result[i] = elements;
                }

                else
                {
                    double el = double.Parse(data[i]);
                    double finalresult = el - (int)el;
                    result[i] = Math.Round(finalresult, 2);
                }
                Console.Write($"{result[i]}  ");
            }
        }
    }
}