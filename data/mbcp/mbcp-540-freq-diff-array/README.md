# mbcp540 -- Calculate frequency range in an array with Python

## Text

Write a C# function to find the difference between highest and least frequencies in a given array.

## Code

```csharp
public static int FindDiff(int[] arr, int n) 
{ 
    Array.Sort(arr); 
    int count = 0; 
    int maxCount = 0; 
    int minCount = n; 

    for (int i = 0; i < n - 1; i++) 
    { 
        if (arr[i] == arr[i + 1]) 
        { 
            count++; 
            continue; 
        } 
        else 
        { 
            maxCount = Math.Max(maxCount, count); 
            minCount = Math.Min(minCount, count); 
            count = 0; 
        } 
    } 
    return maxCount - minCount; 
}
```

## Test List

```csharp
Debug.Assert(FindDiff(new int[] { 1, 1, 2, 2, 7, 8, 4, 5, 1, 4 }, 10) == 2);
```

```csharp
Debug.Assert(FindDiff(new int[] { 1, 7, 9, 2, 3, 3, 1, 3, 3 }, 9) == 3);
```

```csharp
Debug.Assert(FindDiff(new int[] { 1, 2, 1, 2 }, 4) == 0);
```
