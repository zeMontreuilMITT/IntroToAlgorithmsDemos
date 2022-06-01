// a function to check if a number is "perfect" (the sum of its divisors)

Console.WriteLine(IsPerfectNumber(12));
Console.WriteLine(IsPerfectNumber(6));

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