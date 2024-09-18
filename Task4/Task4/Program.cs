class Program
{
    /// <summary>
    /// Main method that reads a text and a search word from the user, then calculates how many times the search word appears in the text, ignoring case.
    /// </summary>
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