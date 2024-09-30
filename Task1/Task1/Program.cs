using System.Text;
using Task1.Exeptions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");

        try
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new NotPositiveIntegerException();
            }

            StringBuilder builder = new StringBuilder($"Число {number} является ", 100);
            builder.Append(IsEvenNumber(number) ? "четным и " : "нечетным и ");

            builder.Append(number > 1
            ? (IsPrimeNumber(number) ? "простым" : "составным")
            : "должно быть больше 1, чтобы быть простым или составным");

            Console.WriteLine(builder);
        }
        catch (OverflowException)
        {
            Console.WriteLine(" Error: число превышает допустимый диапазон значений!");
            Environment.Exit(1);
        }
        catch (FormatException)
        {
            Console.WriteLine(" Error: неверный формат ввода!");
            Environment.Exit(1);
        }
        catch (NotPositiveIntegerException)
        {
            Console.WriteLine(" Error: введено отрицательное число!");
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
        if (IsEvenNumber(number))
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}