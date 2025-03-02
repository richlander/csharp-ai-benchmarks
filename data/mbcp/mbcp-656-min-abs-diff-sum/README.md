# mbcp656 -- Find minimum sum of absolute differences in arrays

## Text

Write a C# function to find the minimum sum of absolute differences of two arrays.

## Code

```csharp
public static int FindMinSum(int[] a, int[] b, int n) 
{ 
    Array.Sort(a); 
    Array.Sort(b); 
    int sum = 0; 
    for (int i = 0; i < n; i++) 
    { 
        sum += Math.Abs(a[i] - b[i]); 
    } 
    return sum; 
}
```

## Test List

```csharp
Debug.Assert(FindMinSum(new int[] { 3, 2, 1 }, new int[] { 2, 1, 3 }, 3) == 0);
```

```csharp
Debug.Assert(FindMinSum(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, 3) == 9);
```

```csharp
Debug.Assert(FindMinSum(new int[] { 4, 1, 8, 7 }, new int[] { 2, 3, 6, 5 }, 4) == 6);
```
