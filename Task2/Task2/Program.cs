class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое целое число:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Введите второе целое число:");
        string input2 = Console.ReadLine();
        
        if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
        {            
            int nod = NOD(number1, number2);
            Console.WriteLine($"НОД чисел {number1} и {number2} = {nod}");            
            int nok = NOK(number1, number2, nod);
            Console.WriteLine($"НОК чисел {number1} и {number2} = {nok}");
        }
        else
        {
            Console.WriteLine(" Error: одно или оба введённых значения не являются целыми числами ");
        }
    }    
    // метод вычисления нод 
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
    // метод вычисления нок
    static int NOK(int a, int b, int nod)
    {
        return Math.Abs(a * b) / nod;
    }
}