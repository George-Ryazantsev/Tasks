using Task2.Exeptions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число: ");
        int number1 = IsValidNumber(Console.ReadLine(), "первое");

        Console.WriteLine("Введите второе число: ");
        int number2 = IsValidNumber(Console.ReadLine(), "второе");

        int nod = NOD(number1, number2);
        int nok = NOK(number1, number2, nod);

        Console.WriteLine($"НОД и НОК чисел {number1} и {number2} : {nod} и " + nok);
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
        catch (FormatException)
        {
            Console.WriteLine($"Error: Неверный формат ввода для {numberPosition} числа!");
            Environment.Exit(1);
        }
        catch (OverflowException)
        {
            Console.WriteLine($"Error: {numberPosition} число превышает допустимый диапазон значений!");
            Environment.Exit(1);
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