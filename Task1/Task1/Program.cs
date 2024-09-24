using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Task1.Exeptions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        string input = Console.ReadLine();
        int number;

        string pattern = @"^\d+$";
        bool isOnlyDigits = Regex.IsMatch(input, pattern);

        if (!isOnlyDigits)
        {
            throw new BadInputTypeException();
        }

        if (!int.TryParse(input, out number))
        {
            throw new OverFlowException();
        }

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