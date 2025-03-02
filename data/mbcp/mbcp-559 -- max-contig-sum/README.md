# mbcp-559 -- Find largest sum of contiguous subarray in array

## Text

Write a function to find the largest sum of contiguous subarray in the given array.

## Code

```csharp
public int MaxSubArraySum(int[] a, int size) {
    int maxSoFar = 0;
    int maxEndingHere = 0;
    for (int i = 0; i < size; i++) {
        maxEndingHere += a[i];
        if (maxEndingHere < 0) {
            maxEndingHere = 0;
        } else if (maxSoFar < maxEndingHere) {
            maxSoFar = maxEndingHere;
        }
    }
    return maxSoFar;
}
```

## Test List

```csharp
Debug.Assert(MaxSubArraySum(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 }, 8) == 7);
```

```csharp
Debug.Assert(MaxSubArraySum(new int[] { -3, -4, 5, -2, -3, 2, 6, -4 }, 8) == 8);
```

```csharp
Debug.Assert(MaxSubArraySum(new int[] { -4, -5, 6, -3, -4, 3, 7, -5 }, 8) == 10);
```
