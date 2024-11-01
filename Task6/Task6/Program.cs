class BackpackItem
{
    public int Weight { get; set; }
    public int Value { get; set; }
}
public class Program
{
    static void Main()
    {
        // грузоподъемность рюкзака
        int maxWeight = 80;

        // набор вещей 
        BackpackItem[] items = new BackpackItem[]
        {
            new BackpackItem { Weight = 10, Value = 60 },
            new BackpackItem { Weight = 20, Value = 80 },
            new BackpackItem { Weight = 30, Value = 100 },
            new BackpackItem { Weight = 40, Value = 120 }
        };

        int maxValue = AddToBackpack(maxWeight, items);
        Console.WriteLine($"Максимальная ценность: {maxValue}");
    }

    /// <summary>
    /// Calculates the maximum total value of items that can be placed in a backpack    
    /// </summary>
    /// <param name="maxWeight">The maximum weight capacity of the backpack.</param>
    /// <param name="items">An array of items, where each item has a weight and a value.</param>
    /// <returns>The maximum achievable value that can fit within the given weight limit.</returns>
    private static int AddToBackpack(int maxWeight, BackpackItem[] items)
    {
        int quantity = items.Length;
        int[,] arr = new int[quantity + 1, maxWeight + 1];

        for (int i = 1; i <= quantity; i++)
        {
            for (int j = 1; j <= maxWeight; j++)
            {
                if (items[i - 1].Weight <= j)// вмещается ли в рюкзак 
                {
                    // Выбираем максимальную ценность из двух вариантов: с текущим предметом или без него
                    arr[i, j] = Math.Max(arr[i - 1, j], arr[i - 1, j - items[i - 1].Weight] + items[i - 1].Value);
                }
                else // макс ценность без текущего предмета(если не можем положить)
                {
                    arr[i, j] = arr[i - 1, j];
                }
            }
        }

        return arr[quantity, maxWeight];
    }
}