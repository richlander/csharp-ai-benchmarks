# mbcp-144 -- Sum absolute differences of array pairs

## Text

Write a C# function to find the sum of absolute differences in all pairs of the given array.

## Code

```csharp
public int SumPairs(int[] arr, int n) 
{ 
    int sum = 0; 
    for (int i = n - 1; i >= 0; i--) 
    { 
        sum += i * arr[i] - (n - 1 - i) * arr[i]; 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(SumPairs(new int[] { 1, 8, 9, 15, 16 }, 5) == 74);
```

```csharp
Debug.Assert(SumPairs(new int[] { 1, 2, 3, 4 }, 4) == 10);
```

```csharp
Debug.Assert(SumPairs(new int[] { 1, 2, 3, 4, 5, 7, 9, 11, 14 }, 9) == 188);
```
