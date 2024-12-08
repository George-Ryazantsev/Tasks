﻿class Program
{
    delegate bool PalindromeCheck(int number);
    static void Main()
    {
        Console.WriteLine("Введите число :");
        string input = Console.ReadLine();

        PalindromeCheck checkPalindrome = IsPalindrome;

        if (int.TryParse(input, out int k) && k >= 0 && k <= 100)
        {
            Console.WriteLine($"Числа-палиндромы в диапазоне от 0 до {k}:");

            for (int i = 0; i <= k; i++)
            {
                if (checkPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine(" Ошибка ввода!");
            Environment.Exit(1);
        }      
    }

    /// <summary>
    /// Checks whether the specified integer is a palindrome.
    /// </summary>
    /// <param name="number">The integer to check.</param>
    /// <returns> true if the integer is a palindrome; otherwise, false </returns>
    static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();

        for (int i = 0; i < numStr.Length / 2; i++)
        {
            if (numStr[i] != numStr[numStr.Length - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}