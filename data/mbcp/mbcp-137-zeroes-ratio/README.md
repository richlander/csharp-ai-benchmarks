# mbcp137 -- Calculate the ratio of zeroes in an integer array

## Text

Write a function to find the ration of zeroes in an array of integers.

## Code

```csharp
using System;

public class Program
{
    public static double ZeroCount(int[] nums)
    {
        int n = nums.Length;
        int n1 = 0;
        foreach (int x in nums)
        {
            if (x == 0)
            {
                n1 += 1;
            }
        }
        return Math.Round((double)n1 / n, 2);
    }
}
```

## Test List

```csharp
Debug.Assert(ZeroCount(new int[] { 0, 1, 2, -1, -5, 6, 0, -3, -2, 3, 4, 6, 8 }) == 0.15);
```

```csharp
Debug.Assert(ZeroCount(new int[] { 2, 1, 2, -1, -5, 6, 4, -3, -2, 3, 4, 6, 8 }) == 0.00);
```

```csharp
Debug.Assert(ZeroCount(new int[] { 2, 4, -6, -9, 11, -12, 14, -5, 17 }) == 0.00);
```
