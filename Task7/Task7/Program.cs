using System.Diagnostics;

class CollectionPerformanceAnalyzer
{
    static void Main()
    {
        int itemCount = 100000;

        Console.WriteLine("List<T>:");
        TestList(itemCount);

        Console.WriteLine("\nDictionary<TKey, TValue>:");
        TestDictionary(itemCount);

        Console.WriteLine("\nHashSet<T>:");
        TestHashSet(itemCount);
    }

    /// <summary>
    /// Measures the execution time of a given action
    /// </summary>
    /// <param name="action">The action to measure</param>
    /// <returns>The elapsed time in milliseconds</returns>
    static long MeasureTime(Action action)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();

        return stopwatch.ElapsedMilliseconds;
    }

    /// <summary>
    /// Tests the performance of adding, searching, and removing elements in a List
    /// </summary>
    /// <param name="itemCount">The number of items to be added, searched, and removed</param>
    static void TestList(int itemCount)
    {
        List<int> list = new List<int>();

        long listAddTime = MeasureTime(() =>
        {
            for (int i = 0; i < itemCount; i++)
            {
                list.Add(i);
            }
        });

        Console.WriteLine($"Добавление: {listAddTime} ms");

        long listFindTime = MeasureTime(() =>
        {
            list.Contains(itemCount / 2);
        });

        Console.WriteLine($"Поиск: {listFindTime} ms");

        long listRemoveTime = MeasureTime(() =>
        {
            for (int i = 0; i < itemCount / 2; i++)
            {
                list.Remove(i);
            }
        });

        Console.WriteLine($"Удаление: {listRemoveTime} ms");
    }

    /// <summary>
    /// Tests the performance of adding, searching, and removing elements in a Dictionary
    /// </summary>
    /// <param name="itemCount">The number of items to be added, searched, and removed </param>
    static void TestDictionary(int itemCount)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        long dictionaryAddTime = MeasureTime(() =>
        {
            for (int i = 0; i < itemCount; i++)
            {
                dictionary[i] = i;
            }
        });

        Console.WriteLine($"Добавление: {dictionaryAddTime} ms");

        long dictionaryFindTime = MeasureTime(() =>
        {
            dictionary.ContainsKey(itemCount / 2);
        });

        Console.WriteLine($"Поиск: {dictionaryFindTime} ms");

        long dictionaryRemoveTime = MeasureTime(() =>
        {
            for (int i = 0; i < itemCount / 2; i++)
            {
                dictionary.Remove(i);
            }
        });

        Console.WriteLine($"Удаление: {dictionaryRemoveTime} ms");
    }

    /// <summary>
    /// Tests the performance of adding, searching, and removing elements in a HashSet
    /// </summary>
    /// <param name="itemCount">The number of items to be added, searched, and removed. </param>
    static void TestHashSet(int itemCount)
    {
        HashSet<int> hashSet = new HashSet<int>();

        long hashSetAddTime = MeasureTime(() =>
        {
            for (int i = 0; i < itemCount; i++)
            {
                hashSet.Add(i);
            }
        });

        Console.WriteLine($"Добавление: {hashSetAddTime} ms");

        long hashSetFindTime = MeasureTime(() =>
        {
            hashSet.Contains(itemCount / 2);
        });

        Console.WriteLine($"Поиск: {hashSetFindTime} ms");

        long hashSetRemoveTime = MeasureTime(() =>
        {
            for (int i = 0; i < itemCount / 2; i++)
            {
                hashSet.Remove(i);
            }
        });

        Console.WriteLine($"Удаление: {hashSetRemoveTime} ms");
    }
}