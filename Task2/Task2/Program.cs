﻿class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число: ");
        string input1 = Console.ReadLine();

        Console.WriteLine("Введите второе число: ");
        string input2 = Console.ReadLine();
        try
        {
            int number1 = checked(int.Parse(input1));
            int number2 = checked(int.Parse(input2));

            int nod = NOD(number1, number2);
            Console.WriteLine($"НОД чисел {number1} и {number2} = {nod}");

            int nok = NOK(number1, number2, nod);
            Console.WriteLine($"НОК чисел {number1} и {number2} = {nok}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: превышение допустимого диапазона значений!");
            Environment.Exit(1);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введены нецелые числа или неверный формат!");
            Environment.Exit(1);
        }
    }

    /// <summary>
    /// Calculates the greatest common divisor of two integers using the Euclidean algorithm.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <returns>The greatest common divisor of the two integers.</returns>
    static int NOD(int a, int b)
    {
        while (b != 0)
        {
            int z = b;
            b = a % b;
            a = z;
        }

        return Math.Abs(a);
    }

    /// <summary>
    /// Calculates the least common multiple of two integers using the GCD.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <param name="nod">The greatest common divisor  of the two integers.</param>
    /// <returns>The least common multiple of the two integers.</returns>
    static int NOK(int a, int b, int nod)
    {
        if (nod == 0)
            return 0;

        return Math.Abs(a * b) / nod;
    }
}