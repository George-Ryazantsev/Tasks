class Program
{
    /// <summary>
    /// Main method that reads a text and a search word from the user, then calculates how many times the search word appears in the text, ignoring case.
    /// </summary>
    static async Task Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        Console.WriteLine("Введите слово для поиска:");
        string searchWord = Console.ReadLine();

        int wordCount = await FindWordAsync(input, searchWord);
        Console.WriteLine($"Слово \"{searchWord}\" встречается в тексте {wordCount} раз(а)");
    }

    /// <summary>
    /// Asynchronous method that counts the occurrences of a search word in the text, ignoring case.
    /// </summary>    
    /// <param name="searchWord">Search word</param>
    /// <returns>The number of occurrences of the search word</returns>
    static async Task<int> FindWordAsync(string inputText, string searchWord)
    {
        string lowText = inputText.ToLower();
        string lowWord = searchWord.ToLower();

        int wordCount = 0;
        int index = lowText.IndexOf(lowWord);

        while (index != -1)
        {
            wordCount++;
            index = lowText.IndexOf(lowWord, index + lowWord.Length);
        }

        return wordCount;
    }
}