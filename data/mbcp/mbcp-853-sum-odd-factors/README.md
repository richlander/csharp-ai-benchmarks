# mbcp853 -- Sum odd factors of a number using Python function

## Text

Write a C# function to find sum of odd factors of a number.

## Code

```csharp
public static int SumOfOddFactors(int n) 
{
    int res = 1;
    while (n % 2 == 0) 
    {
        n /= 2;
    }
    for (int i = 3; i <= Math.Sqrt(n); i += 2) 
    {
        int count = 0;
        int currSum = 1;
        int currTerm = 1;
        while (n % i == 0) 
        {
            count++;
            n /= i;
            currTerm *= i;
            currSum += currTerm;
        }
        res *= currSum;
    }
    if (n >= 2) 
    {
        res *= (1 + n);
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(SumOfOddFactors(30) == 24);
```

```csharp
Debug.Assert(SumOfOddFactors(18) == 13);
```

```csharp
Debug.Assert(SumOfOddFactors(2) == 1);
```
