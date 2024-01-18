class reverseString
{
    static void Main()
    {
        // Input 
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Catching the output
        string reversedString = ReverseString(inputString);

        // Output
        Console.WriteLine("Reversed String: " + reversedString);
    }

    static string ReverseString(string input)
    {
        // Converting the string to characters
        char[] charArray = input.ToCharArray();

        // Getting the length of the array
        int length = charArray.Length;

        // Changing characters from the beginning and end of the array
        for (int i = 0; i < length / 2; i++)
        {
            char temp = charArray[i];
            charArray[i] = charArray[length - i - 1];
            charArray[length - i - 1] = temp;
        }

        // Converting the characters to string
        string reversedString = new string(charArray);

        return reversedString;
    }
}