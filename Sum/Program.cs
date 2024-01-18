class Program
{
    static void Main()
    {
        int[] numbers = [1, 2, 3, 4, 5];

        // Catching that sum variable for output
        int sum = SumArray(numbers);

        // Output
        Console.WriteLine("Sum of the array elements: " + sum);

    }
    static int SumArray(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}