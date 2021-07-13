using System;

namespace SimpleCalculatorHW
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInputValue, secondInputValue, result;
            var conditionOfExit = "empty";

            while (conditionOfExit != "exit")
            {
                Console.WriteLine("Введите число");
                try
                {
                    firstInputValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некоректный операнд, допустимы только числа.\nЕсли вы хотите закончить работу каклькулятора то введите команду 'exit', в противном случае оставьте поле пустым.");
                    conditionOfExit = Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберите необходимый оператор: +,-,/,*");
                ConsoleKey inputkey = Console.ReadKey().Key;

                Console.WriteLine("\nВведите число");
                try
                {
                    secondInputValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некоректный операнд, допустимы только числа.\nЕсли вы хотите закончить работу каклькулятора то введите команду 'exit', в противном случае оставьте поле пустым.");
                    conditionOfExit = Console.ReadLine();
                    continue;
                }

                switch (inputkey)
                {
                    case ConsoleKey.Add:
                    case ConsoleKey.OemPlus:
                        result = firstInputValue + secondInputValue;
                        Console.WriteLine("Результат равен " + result);
                        break;
                    case ConsoleKey.Subtract:
                    case ConsoleKey.OemMinus:
                        result = firstInputValue - secondInputValue;
                        Console.WriteLine("Результат равен " + result);
                        break;
                    case ConsoleKey.Divide:
                    case ConsoleKey.Oem2:
                    case ConsoleKey.Oem5:
                        result = firstInputValue / secondInputValue;
                        Console.WriteLine("Результат равен " + result);
                        break;
                    case ConsoleKey.Multiply:
                    case ConsoleKey.D8:
                        result = firstInputValue * secondInputValue;
                        Console.WriteLine("Результат равен " + result);
                        break;
                    default:
                        Console.WriteLine("Введён некоректный оператор " + inputkey + ". Если вы ввели коректный оператор и данное окно всё еще появляется обратитесь к разработчику по электронному адресу: luterfaeron@gmail.com");
                        break;
                }

                Console.WriteLine("Если вы хотите закончить работу каклькулятора то введите команду 'exit', в противном случае оставьте поле пустым.");
                conditionOfExit = Console.ReadLine();
            }

        }
    }
}
