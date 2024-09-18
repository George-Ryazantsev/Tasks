class Program
{
    static void Main()
    {        
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        // Разделение предложения на слова по пробелам
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        int wordCount = words.Length;
        Console.WriteLine($"Количество слов в предложении: {wordCount}");

        // первая буква каждого слова становится заглавной
        string[] capitalizedWords = words.Select(word => ToUpper(word)).ToArray();

        // Сортировка слов в алфавитном порядке
        Array.Sort(capitalizedWords);
        
        Console.WriteLine("Слова в отсортированном виде:");
        foreach (string word in capitalizedWords)
        {
            Console.WriteLine(word);
        }
    }

    // Метод для преобразования первой буквы слова в заглавную
    static string ToUpper(string word)
    {
        if (string.IsNullOrEmpty(word)) return word;
        return char.ToUpper(word[0]) + word.Substring(1).ToLower();
    }
}