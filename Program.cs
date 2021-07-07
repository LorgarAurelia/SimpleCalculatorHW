using System;

namespace SimpleCalculatorHW
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInputValue,secondInputValue,result;

            Console.WriteLine("Введите число");
            firstInputValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите необходимы оператор: +,-,/,*");
            ConsoleKey inputkey = Console.ReadKey().Key;

            switch (inputkey)
            {
                case ConsoleKey.Add:
                case ConsoleKey.OemPlus:
                    Console.WriteLine("Введите число");
                    secondInputValue = double.Parse(Console.ReadLine());
                    result = firstInputValue + secondInputValue;
                    Console.WriteLine("Результат равен " + result);
                    break;
                case ConsoleKey.Subtract:
                case ConsoleKey.OemMinus:
                    Console.WriteLine("Введите число");
                    secondInputValue = double.Parse(Console.ReadLine());
                    result = firstInputValue - secondInputValue;
                    Console.WriteLine("Результат равен " + result);
                    break;
                case ConsoleKey.Divide:
                case ConsoleKey.Oem2:
                case ConsoleKey.Oem5:
                    Console.WriteLine("Введите число");
                    secondInputValue = double.Parse(Console.ReadLine());
                    result = firstInputValue / secondInputValue;
                    Console.WriteLine("Результат равен " + result);
                    break;
                default:
                    Console.WriteLine("Введён некоректный оператор " + inputkey);
                    break;
            }
        }
    }
}
