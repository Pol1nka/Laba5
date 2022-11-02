using System;

namespace Laboratorka5
{
    public static class Program
    {
        public static void Main()
        {
            int num1 = ReadInt();
            float num2 = ReadFloat();
            char num3 = ReadChar();
            IntAndFloat(num1, num2);
            SumIntAndFloat(num1, num2);
            IntAndChar(num1, num3);
        }
        public static int ReadInt()
        {
            Console.Write("int ");
            bool isInt = int.TryParse(Console.ReadLine(), out int num);
            while (!isInt)
            {
                Console.Write("Некорректный ввод. Попробуйте ещё раз: ");
                isInt = int.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }
        public static float ReadFloat()
        {
            Console.Write("float ");
            bool isInt = float.TryParse(Console.ReadLine(), out float num);
            while (!isInt)
            {
                Console.Write("Некорректное число. Попробуйте ещё раз: ");
                isInt = float.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }
        public static char ReadChar()
        {
            Console.Write("char ");
            bool isInt = char.TryParse(Console.ReadLine(), out char num);
            while (!isInt)
            {
                Console.Write("Некорректное число. Попробуйте ещё раз: ");
                isInt = char.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }
        public static void IntAndFloat(int num1, float num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Числа типа float И int, введенные раннее равны.");
            }
            else if (num1 > num2)
            {
                Console.WriteLine($"Числа типа float И int, введенные раннее не равны. {num1} > {num2}");
            }
            else
            {
                Console.WriteLine($"Числа типа float И int, введенные раннее не равны. {num1} < {num2}");
            }
        }
        public static void SumIntAndFloat(int num1, float num2)
        {
            var sum = num1 + num2;
            Console.WriteLine($"Сумма чисел типа float И int имеет тип float.");
        }
        public static void IntAndChar(int num1, char num2)
        {
            if (num1 == (int)num2)
            {
                Console.WriteLine("Числа типа int и char, введенные раннее равны.");
            }
            else if (num1 > (int)num2)
            {
                Console.WriteLine($"Числа типа int и char, введенные раннее не равны. {num1} > {num2}");
            }
            else
            {
                Console.WriteLine($"Числа типа int и char , введенные раннее не равны. {num1} < {num2}");
            }
            char num3 = (char)num1;
            Console.WriteLine($"Перевод числа типа int {num1} в тип char {num3}.");
        }
    }
}