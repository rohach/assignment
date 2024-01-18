class uniqueElement
{
    static void Main()
    {
        int[] inputArray = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 8, 1 };

        int[] uniqueArray = GetUniqueElements(inputArray);

        Console.WriteLine("Original Array: " + string.Join(", ", inputArray));
        Console.WriteLine("Unique Elements: " + string.Join(", ", uniqueArray));
    }

    static int[] GetUniqueElements(int[] inputArray)
    {
        return inputArray.Distinct().ToArray();
    }
}