class Program
{
    static void Main()
    {        
        Console.WriteLine("Введите число :");
        string input = Console.ReadLine();
       
        if (int.TryParse(input, out int k) && k >= 0 && k <= 100)
        {
            Console.WriteLine($"Числа-палиндромы в диапазоне от 0 до {k}:");  
            
            for (int i = 0; i <= k; i++)
            {
                if (IsPalindrome(i))
                {
                  Console.WriteLine(i);
                }
            }
        }
        else
        {
          Console.WriteLine(" Error: Ошибка ввода!!!");
        }
    }

    /// <summary>
    /// Checks whether the specified integer is a palindrome.
    /// </summary>
    /// <param name="number">The integer to check.</param>
    /// <returns>
    /// <c>true</c> if the integer is a palindrome; otherwise, <c>false</c>.
    /// A palindrome is a number that reads the same forward and backward.
    /// </returns>
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