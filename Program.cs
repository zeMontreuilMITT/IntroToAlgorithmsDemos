// a function to check if a number is "perfect" (the sum of its divisors)
// a function that will create an array for another function


//Console.WriteLine(IsPerfectNumber(12));
//Console.WriteLine(IsPerfectNumber(6));

int[] testValues = GetIntegersFromUser();
FindDuplicateNumbers(testValues);

bool IsPerfectNumber(int testValue)
{
    int runningTotal = 0;

    for (int i = testValue / 2; i > 0; i--)
    {
        if (testValue % i == 0)
        {
            runningTotal += i;
        }

        if (testValue < runningTotal)
        {
            return false;
        }
    }

    return testValue == runningTotal;
}

// function for finding all duplicate values in an array of integersand returning them in a new array]

int[] FindDuplicateNumbers(int[] numbers)
{
    int[] duplicateNumbers = new int[0];

    // [ 1, 2, ,2 ,3, 4, 3, 2, 7 ]
    // [2, 3]

    for(int outerIndex = 0; outerIndex < numbers.Length; outerIndex++)
    {
        for(int innerIndex = outerIndex + 1; innerIndex < numbers.Length; innerIndex++)
        {
            if(numbers[innerIndex] == numbers[outerIndex])
            {
                bool alreadyContained = false;

                for(int dupeIndex = 0; dupeIndex < duplicateNumbers.Length; dupeIndex++)
                {
                    if (duplicateNumbers[dupeIndex] == numbers[innerIndex])
                    {
                        alreadyContained = true;
                        dupeIndex = duplicateNumbers.Length;
                    }
                }

                if (!alreadyContained)
                {
                    Array.Resize(ref duplicateNumbers, duplicateNumbers.Length + 1);
                    duplicateNumbers[duplicateNumbers.Length - 1] = numbers[innerIndex];
                    innerIndex = numbers.Length;
                }
            }
        }
    }

    return duplicateNumbers;
}

int[] GetIntegersFromUser()
{
    int[] numbers = new int[0];

    Console.WriteLine("Enter a number, or q to stop");

    string inputString = Console.ReadLine();

    while(inputString != "q")
    {
        Array.Resize(ref numbers, numbers.Length + 1);
        numbers[numbers.Length - 1] = int.Parse(inputString);
        inputString = Console.ReadLine();
    }

    return numbers;
}