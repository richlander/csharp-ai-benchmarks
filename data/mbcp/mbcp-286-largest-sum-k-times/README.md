# mbcp286 -- Find the largest sum in repeated array segments

## Text

Write a function to find the largest sum of contiguous array in the modified array which is formed by repeating the given array k times.

## Code

```csharp
public static int MaxSubArraySumRepeated(int[] a, int n, int k) 
{
    int maxSoFar = int.MinValue;
    int maxEndingHere = 0;
    for (int i = 0; i < n * k; i++) 
    {
        maxEndingHere += a[i % n];
        if (maxSoFar < maxEndingHere) 
        {
            maxSoFar = maxEndingHere;
        }
        if (maxEndingHere < 0) 
        {
            maxEndingHere = 0;
        }
    }
    return maxSoFar;
}
```

## Test List

```csharp
Debug.Assert(MaxSubArraySumRepeated(new int[] { 10, 20, -30, -1 }, 4, 3) == 30);
```

```csharp
Debug.Assert(MaxSubArraySumRepeated(new int[] { -1, 10, 20 }, 3, 2) == 59);
```

```csharp
Debug.Assert(MaxSubArraySumRepeated(new int[] { -1, -2, -3 }, 3, 3) == -1);
```
