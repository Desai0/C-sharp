using System;

public class DivisionByZeroException : Exception
{
    public DivisionByZeroException(string message)
        : base(message)
    {
    }
}

public class InvalidOperationException : Exception
{
    public InvalidOperationException(string message)
        : base(message) { }
}

class Program
{
    static void Main()
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                double firstC = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                double secondC = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите операцию: '+', '-', '/', '*'");
                string operationInput = Console.ReadLine();
                char operation;

                if (string.IsNullOrEmpty(operationInput) || operationInput.Length != 1)
                {
                    throw new InvalidOperationException("Операция должна быть одним символом.");
                }
                operation = operationInput[0];

                double result;

                switch (operation)
                {
                    case '+':
                        result = firstC + secondC;
                        break;
                    case '-':
                        result = firstC - secondC;
                        break;
                    case '/':
                        if (secondC == 0)
                        {
                            throw new DivisionByZeroException("Деление на ноль запрещено.");
                        }
                        result = firstC / secondC;
                        break;
                    case '*':
                        result = firstC * secondC;
                        break;
                    default:
                        throw new InvalidOperationException($"Неизвестная операция: '{operation}'. Допустимые операции: '+', '-', '*', '/'.");
                }

                Console.WriteLine($"Результат: {result}");

                Console.WriteLine("Введите '0' чтобы продолжить или любую другую клавишу для выхода.");
                string choice = Console.ReadLine();
                if (choice != "0")
                {
                    continueCalculating = false;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено некорректное число. Пожалуйста, попробуйте снова.");
            }
            catch (DivisionByZeroException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message} Пожалуйста, попробуйте снова.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message} Пожалуйста, попробуйте снова.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message} Пожалуйста, попробуйте снова.");
            }
        }
        Console.WriteLine("Калькулятор завершил работу.");
    }
}