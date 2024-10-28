using WordCounterLibrary;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        WordCounter.Count(input);                
    }
}