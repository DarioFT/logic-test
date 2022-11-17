
// Encode sucesive text inputs until user inputs an empty string.
bool stopInput = false;
while (!stopInput)
{
    Console.WriteLine("Please input the text to encode:");
    string? textInput = Console.ReadLine();
    if (!string.IsNullOrEmpty(textInput))
    {
        // Process text input and compute bound conditions for rows and columns.
        string text = textInput.Replace(" ", "");
        double textLenght = text.Length;
        double textLenghtSqrt = Math.Sqrt(textLenght);
        int lowerBound = (int)Math.Floor(textLenghtSqrt);
        int upperBound = (int)Math.Ceiling(textLenghtSqrt);

        string encodedText;

        if (lowerBound * upperBound >= textLenght)
            encodedText = EncodeTextTableToString(BuildTextTable(lowerBound, upperBound, text));
        else
            encodedText = EncodeTextTableToString(BuildTextTable(upperBound, upperBound, text));

        Console.WriteLine(encodedText);
    }
    else stopInput = true;
}

// Writes a table defined by precomputed bounds to store a given text.
char[,] BuildTextTable(int lowerBound, int upperBound, string text)
{
    char[,] textTable = new char[lowerBound, upperBound]; ;
    int k = 0;
    int textLength = text.Length;
    for (int i = 0; i < lowerBound; i++)
        for (int j = 0; j < upperBound; j++)
        {
            if (k < textLength) textTable[i, j] = text[k];
            k++;
        }
    return textTable;

}

// Returns a string with an encoded text given a text table storage.
string EncodeTextTableToString(char[,] textTable)
{
    string encodedText = "";
    int upperBound = textTable.GetLength(1);
    int lowerBound = textTable.GetLength(0);
    for (int i = 0; i < upperBound; i++)
    {
        for (int j = 0; j < lowerBound; j++)
        {
            encodedText = encodedText + textTable[j, i];
        }
        encodedText = encodedText + " ";
    }
    return encodedText;
}