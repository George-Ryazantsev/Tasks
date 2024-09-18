class Program
{
    static void Main()
    {
        int wordCount = 0;
        Console.WriteLine("Введите текст:");
        string inputText = Console.ReadLine();        
        Console.WriteLine("Введите слово для поиска:");
        string searchWord = Console.ReadLine();        
        string lowText = inputText.ToLower();
        string lowWord = searchWord.ToLower();                
        int index = lowText.IndexOf(lowWord);        
        while (index != -1)
        {
            wordCount++;
            index = lowText.IndexOf(lowWord, index + lowWord.Length);
        }        
        Console.WriteLine($"Слово \"{searchWord}\" встречается в тексте {wordCount} раз(а)");
    }
}