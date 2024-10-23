using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        string[] capitalizedWords = RegexActions(ref input).Select(word => ToUpper(word)).ToArray();

        Array.Sort(capitalizedWords, StringComparer.CurrentCultureIgnoreCase);

        Console.WriteLine("Слова в отсортированном виде:");
        foreach (string word in capitalizedWords)
        {
            Console.WriteLine(" " + word);
        }
    }

    /// <summary>
    /// Converts the first letter of the given word to uppercase, and the rest to lowercase.
    /// </summary>
    /// <param name="word">The word to be transformed.</param>
    /// <returns> The transformed word with the first letter in uppercase and the remaining letters in lowercase. </returns>
    static string ToUpper(string word)
    {
        if (string.IsNullOrEmpty(word))
            return word;

        return char.ToUpper(word[0]) + word.Substring(1);
    }

    /// <summary>
    /// Extracts words and numbers from the input string using a regular expression and returns them as an array, counts the number of words or numeric sequences.    
    /// </summary>
    /// <param name="input">The input string from which words and numbers will be extracted. Passed by reference.</param>
    /// <returns> An array of strings containing only the words and numbers found in the input.</returns>
    static string[] RegexActions(ref string input)
    {
        string pattern = @"\w+";
        MatchCollection matches = Regex.Matches(input, pattern);

        string[] words = matches.Cast<Match>().Select(m => m.Value).ToArray();
        int wordCount = words.Length;
        Console.WriteLine($"Количество слов в предложении: {wordCount}");

        return words;
    }
}