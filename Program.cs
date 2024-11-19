namespace ConsoleApp24
{
    using System;

    class Program
    {
        // Оголошення делегата для функції
        delegate double Function(double x);

        // Реалізація функції для x > 0
        static double F_Positive(double x)
        {
            return 1 / x;
        }

        // Реалізація функції для x < 0
        static double F_Negative(double x)
        {
            return x * x + 2 * x + 4;
        }

        // Реалізація функції для x == 0
        static double F_Zero(double x)
        {
            return 4;
        }

        static void Main(string[] args)
        {
            Console.Write("Введіть значення x: ");
            string input = Console.ReadLine();

            // Перевірка на введення
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Потрібно було ввести число");
                return;
            }

            // Спроба перетворити введене значення в число
            if (!double.TryParse(input, out double x))
            {
                Console.WriteLine("Введено нечислове значення");
                return;
            }

            // Оголошення делегата
            Function function;

            // Вибір відповідної функції на основі значення x
            if (x > 0)
            {
                function = F_Positive;
            }
            else if (x < 0)
            {
                function = F_Negative;
            }
            else
            {
                function = F_Zero;
            }

            // Обчислення результату
            double result = function(x);
            Console.WriteLine($"F({x}) = {result}");
        }
    }

}
