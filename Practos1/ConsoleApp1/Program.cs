using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выход");

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 9)
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                continue;
            }

            if (choice == 9)
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Неверный ввод числа. Попробуйте снова.");
                continue;
            }

            double num2 = 0; // Инициализируем num2 нулем по умолчанию

            if (choice != 6 && choice != 7 && choice != 8)
            {
                Console.Write("Введите второе число: ");
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Неверный ввод числа. Попробуйте снова.");
                    continue;
                }
            }

            double result = 0; // Инициализируем result нулем по умолчанию

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Деление на ноль невозможно.");
                    break;
                case 5:
                    Console.Write("Введите степень N: ");
                    if (int.TryParse(Console.ReadLine(), out int power))
                        result = Math.Pow(num1, power);
                    else
                        Console.WriteLine("Неверный ввод степени. Попробуйте снова.");
                    break;
                case 6:
                    if (num1 >= 0)
                        result = Math.Sqrt(num1);
                    else
                        Console.WriteLine("Нельзя извлекать корень из отрицательного числа.");
                    break;
                case 7:
                    result = num1 / 100;
                    break;
                case 8:
                    if (num1 >= 0)
                        result = CalculateFactorial((int)num1);
                    else
                        Console.WriteLine("Факториал отрицательного числа не существует.");
                    break;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }

    static double CalculateFactorial(int n)
    {
        if (n < 0)
            return double.NaN; // Возврат NaN для неправильного ввода
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}