class Program
{
    static void Main()
    {        
        Console.WriteLine("Введите N :");
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
    // метод для проверки числа на палиндромность 
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