using Task2.Exceptions;
using Task2.Exeptions;

class Program
{
    static void Main()
    {
        int number1 = RequestNumber("первое");
        int number2 = RequestNumber("второе");

        int nod = NOD(number1, number2);
        int nok = NOK(number1, number2, nod);

        Console.WriteLine($"НОД чисел {number1} и {number2} : {nod}");
        Console.WriteLine($"НОК чисел {number1} и {number2} : {nok}");
    }

    /// <summary>
    /// Prompts the user to enter a number for a given position, validates the input
    /// and returns the parsed integer value.
    /// </summary>
    /// <param name="numberPosition">The label of the number position used for display in prompts and error messages.</param>
    /// <returns>The validated integer number entered by the user.</returns>
    private static int RequestNumber(string numberPosition)
    {
        Console.WriteLine($"Введите {numberPosition} число: ");

        try
        {
            return IsValidNumber(Console.ReadLine(), numberPosition);
        }
        catch (CustomFormatException ex)
        {
            Console.WriteLine($"Original Exception: {ex.InnerException?.Message}");
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }
        catch (CustomOverflowException ex)
        {
            Console.WriteLine($"Original Exception: {ex.InnerException?.Message}");
            Console.WriteLine(ex.Message);
            Environment.Exit(1);
        }

        return -1;
    }

    /// <summary>
    /// Checks if the entered string is a valid number. In case of invalid input,
    /// prints an error message and terminates the program.
    /// </summary>
    /// <param name="input">The string containing the input number.</param>
    /// <param name="numberPosition">The position of the number (e.g., "first" or "second"), used to indicate which number is invalid.</param>
    /// <returns>Returns the parsed integer if the input is valid, or terminates the program in case of an error.</returns>
    /// <exception cref="FormatException">Thrown when the input is not a valid number format.</exception>
    /// <exception cref="OverflowException">Thrown when the input number exceeds the allowed range of values.</exception>
    /// <exception cref="NotPositiveIntegerException">Thrown when the input is a negative integer.</exception>
    private static int IsValidNumber(string? input, string numberPosition)
    {
        try
        {
            int number = int.Parse(input);

            if (number < 0)
            {
                throw new NotPositiveIntegerException();
            }

            return number;
        }
        catch (FormatException ex)
        {
            throw new CustomFormatException($"Error: Неверный формат ввода для {numberPosition} числа!", numberPosition, ex);
        }
        catch (OverflowException ex)
        {
            throw new CustomOverflowException($"Error: {numberPosition} число превышает допустимый диапазон значений!", numberPosition, ex);
        }
        catch (NotPositiveIntegerException)
        {
            Console.WriteLine("Error: Введено отрицательное число!");
            Environment.Exit(1);
        }

        return -1;
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