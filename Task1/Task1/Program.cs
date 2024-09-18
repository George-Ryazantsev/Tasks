class Program
{
    static void Main(string[] args)
    {
        string input;
        string mes = "end";
        do
        {    
             Console.WriteLine("Введите целое число:");
             input = Console.ReadLine();
            // Проверка на целое
            if (int.TryParse(input, out int number))
            {
                if (IsEvenNumber(number))
                {
                    Console.WriteLine($"Число {number} является четным");
                }               
                else Console.WriteLine($"Число {number} является нечетным");
                if (IsPrimeNumber(number))
                {
                    Console.WriteLine($"Число {number} является простым");
                }
                else if (number > 1)
                {
                    Console.WriteLine($"Число {number} является составным");
                }
                else
                {
                    Console.WriteLine("Число должно быть больше 1, чтобы оно было простым или составным");
                }
            }
            else 
            {
                if (input == mes || string.IsNullOrEmpty(input)) break;
                Console.WriteLine(" Ошибка ввода!");
            }

        } while (input != null || input != mes);

    }

    // метод для проверки числа на четность
    private static bool IsEvenNumber(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else return false;        
    }

    // метод для проверки числа (простое/составное)    
    private static bool IsPrimeNumber(int number)
    {
        if (number <= 1) return false; // Т.к. простые числа больше 1 
        if (number == 2) return true; // 2 — единственное чётное простое число
        if (number % 2 == 0) return false; // Чётные числа кроме 2, не являются простыми
        
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}