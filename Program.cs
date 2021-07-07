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
                case ConsoleKey.Multiply:
                case ConsoleKey.D8:
                    Console.WriteLine("Введите число");
                    secondInputValue = double.Parse(Console.ReadLine());
                    result = firstInputValue * secondInputValue;
                    Console.WriteLine("Результат равен " + result);
                    break;
                default:
                    Console.WriteLine("Введён некоректный оператор " + inputkey + ". Если вы ввели коректный оператор и данное окно всё еще появляется обратитесь к разработчику по электронному адресу: luterfaeron@gmail.com");
                    break;
            }
        }
    }
}
