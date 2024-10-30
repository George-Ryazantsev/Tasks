using System.Text.RegularExpressions;
using Task4;

class Program
{
    /// <summary>
    /// Main method that reads a text and a search word from the user, then calculates how many times the search word appears in the text, ignoring case.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        Console.WriteLine("Введите слово для поиска:");
        string searchWord = Console.ReadLine();

        int wordCount = FindWord(input, searchWord);

        string message = string.Format(Messages.WordOccurrenceMessage, searchWord, wordCount);
        Console.WriteLine(message);
    }

    /// <summary>
    /// Method that counts the occurrences of a search word in the text, ignoring case.
    /// </summary>    
    /// <param name="searchWord">Search word</param>
    /// <returns>The number of occurrences of the search word</returns>
    private static int FindWord(string inputText, string searchWord)
    {
        string pattern = $@"\b{Regex.Escape(searchWord)}\b";
        MatchCollection matches = Regex.Matches(inputText, pattern, RegexOptions.IgnoreCase);

        return matches.Count;
    }
}