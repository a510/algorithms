using System;

class Program
{
    private static readonly Random _random = new();

    static void Main()
    {
        var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Shuffle(arr);

        Console.WriteLine(string.Join(", ", arr));
    }

    /// <summary>
    /// Shuffles an array of integers in-place
    /// </summary>
    /// <param name="input">the array to be shuffled</param>
    private static void Shuffle(int[] input)
    {
        for (var i = 0; i < input.Length; i++)
        {
            var j = _random.Next(0, input.Length);
            (input[i], input[j]) = (input[j], input[i]);
        }
    }
}