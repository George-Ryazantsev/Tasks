class Program
{
    static void Main()
    {        
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        int wordCount = words.Length;
        Console.WriteLine($"Количество слов в предложении: {wordCount}");
        
        string[] capitalizedWords = words.Select(word => ToUpper(word)).ToArray();
        
        Array.Sort(capitalizedWords);
        
        Console.WriteLine("Слова в отсортированном виде:");

        foreach (string word in capitalizedWords)
        {
            Console.WriteLine(word);
        }
    }

    /// <summary>
    /// Converts the first letter of the given word to uppercase, and the rest to lowercase.
    /// </summary>
    /// <param name="word">The word to be transformed.</param>
    /// <returns>
    /// The transformed word with the first letter in uppercase and the remaining letters in lowercase.
    /// If the input string is null or empty, the original string is returned.
    /// </returns>
    static string ToUpper(string word)
    {
        if (string.IsNullOrEmpty(word)) 
            return word;

        return char.ToUpper(word[0]) + word.Substring(1).ToLower();
    }
}