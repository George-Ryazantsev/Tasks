﻿using System.Linq.Expressions;
using System.Text.RegularExpressions;

class ProgramVar2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);

            if (IsEvenNumber(number))
            {
                Console.WriteLine($"Число {number} является четным");
            }
            else
            {
                Console.WriteLine($"Число {number} является нечетным");
            }

            if (IsPrimeNumber(number))
            {
                Console.WriteLine($"Число {number} является простым");
            }
            else
            {
                if (number > 1)
                {
                    Console.WriteLine($"Число {number} является составным");
                }
                else
                {
                    Console.WriteLine("Число должно быть больше 1, чтобы оно было простым или составным");
                }
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
    }

    /// <summary>
    /// Determines whether the specified integer is an even number.
    /// </summary>
    /// <param name="number">The integer to check.</param>
    /// <returns> true if the specified integer is even; otherwise, false. </returns>
    private static bool IsEvenNumber(int number)
    {
        return number % 2 == 0;
    }

    /// <summary>
    /// Determines whether the specified integer is a prime number.
    /// </summary>
    /// <param name="number">The integer to check.</param>
    /// <returns> true if the specified integer is a prime number; otherwise, false. </returns>  
    private static bool IsPrimeNumber(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}