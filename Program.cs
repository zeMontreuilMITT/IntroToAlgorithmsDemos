int[] testInts = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
Console.WriteLine(String.Join(' ', GetAllOddNumbers(testInts)));


int[] GetAllOddNumbers(int[] integers)
{
    // declared arrays need a length
    int[] oddNumbers = new int[integers.Length];
    int oddCounter = 0;

    for(int index = 0; index < integers.Length; index++)
    {
        if(integers[index] % 2 == 0)
        {
            Array.Resize(ref oddNumbers, oddNumbers.Length - 1);
        }
        else
        {
            oddNumbers[oddCounter] = integers[index];
            oddCounter++;
        }
    }

    return oddNumbers;
}