class minMax
{
    static void Main()
    {
        int[] numbers = [1, 3, 4, 8, 5, 2, 6, 9, 0, 7];

        // Declaring a variable for both min and max
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
                min = numbers[i];

            if (numbers[i] > max)
                max = numbers[i];
        }
        Console.WriteLine("Minimum Element: " + min);
        Console.WriteLine("Maximum Element: " + max);
    }
}