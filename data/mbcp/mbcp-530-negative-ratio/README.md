# mbcp530 -- Calculate the ratio of negative integers in an array

## Text

Write a function to find the ration of negative numbers in an array of integers.

## Code

```csharp
using System;

public class Program
{
    public static double NegativeCount(double[] nums)
    {
        int n = nums.Length;
        int n1 = 0;
        foreach (var x in nums)
        {
            if (x < 0)
            {
                n1++;
            }
        }
        return Math.Round((double)n1 / n, 2);
    }
}
```

## Test List

```csharp
Debug.Assert(NegativeCount(new int[] { 0, 1, 2, -1, -5, 6, 0, -3, -2, 3, 4, 6, 8 }) == 0.31);
```

```csharp
Debug.Assert(NegativeCount(new int[] { 2, 1, 2, -1, -5, 6, 4, -3, -2, 3, 4, 6, 8 }) == 0.31);
```

```csharp
Debug.Assert(NegativeCount(new List<int> { 2, 4, -6, -9, 11, -12, 14, -5, 17 }) == 0.44);

public double NegativeCount(List<int> numbers)
{
    int negativeCount = numbers.Count(n => n < 0);
    return (double)negativeCount / numbers.Count;
}
```
