# mbcp831 -- Count pairs of equal elements in an array

## Text

Write a C# function to count equal element pairs from the given array.

## Code

```csharp
public int CountPairs(int[] arr, int n) 
{ 
    int cnt = 0; 
    for (int i = 0; i < n; i++) 
    { 
        for (int j = i + 1; j < n; j++) 
        { 
            if (arr[i] == arr[j]) 
            { 
                cnt++; 
            } 
        } 
    } 
    return cnt; 
}
```

## Test List

```csharp
Debug.Assert(CountPairs(new int[] { 1, 1, 1, 1 }, 4) == 6);
```

```csharp
Debug.Assert(CountPairs(new int[] { 1, 5, 1 }, 3) == 1);
```

```csharp
Debug.Assert(CountPairs(new int[] { 3, 2, 1, 7, 8, 9 }, 6) == 0);
```
