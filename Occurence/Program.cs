class uniqueElements
{
    static void Main()
    {
        string inputString = "hello world";

        Dictionary<char, int> charOccurrences = CountCharacterOccurrences(inputString);

        Console.WriteLine("String: " + inputString);
        Console.WriteLine("Character Occurrences:");
        foreach (var kvp in charOccurrences)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} times");
        }
    }

    static Dictionary<char, int> CountCharacterOccurrences(string inputString)
    {
        Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

        foreach (char c in inputString)
        {
            if (charOccurrences.ContainsKey(c))
            {
                charOccurrences[c]++;
            }
            else
            {
                charOccurrences[c] = 1;
            }
        }

        return charOccurrences;
    }
}