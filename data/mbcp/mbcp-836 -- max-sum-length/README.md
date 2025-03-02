# mbcp-836 -- Find length of subarray with maximum sum

## Text

Write a function to find length of the subarray having maximum sum.

## Code

```csharp
using System;

public class Program
{
    public static int MaxSubArraySum(int[] a, int size)
    {
        int maxSoFar = int.MinValue;
        int maxEndingHere = 0;
        int start = 0;
        int end = 0;
        int s = 0;

        for (int i = 0; i < size; i++)
        {
            maxEndingHere += a[i];

            if (maxSoFar < maxEndingHere)
            {
                maxSoFar = maxEndingHere;
                start = s;
                end = i;
            }

            if (maxEndingHere < 0)
            {
                maxEndingHere = 0;
                s = i + 1;
            }
        }

        return end - start + 1;
    }
}
```

## Test List

```csharp
Debug.Assert(MaxSubArraySum(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 }) == 5);

public static int MaxSubArraySum(int[] arr) {
    // Implementation of MaxSubArraySum goes here
}
```

```csharp
Debug.Assert(MaxSubArraySum(new int[] { 1, -2, 1, 1, -2, 1 }, 6) == 2);
```

```csharp
Debug.Assert(MaxSubArraySum(new int[] { -1, -2, 3, 4, 5 }, 5) == 3);
```
