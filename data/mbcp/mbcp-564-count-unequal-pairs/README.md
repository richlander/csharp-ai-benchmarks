# mbcp564 -- Count unequal element pairs in an array

## Text

Write a C# function to count unequal element pairs from the given array.

## Code

```csharp
public int CountPairs(int[] arr, int n) 
{ 
    int cnt = 0; 
    for (int i = 0; i < n; i++) 
    { 
        for (int j = i + 1; j < n; j++) 
        { 
            if (arr[i] != arr[j]) 
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
Debug.Assert(CountPairs(new int[] { 1, 2, 1 }, 3) == 2);
```

```csharp
Debug.Assert(CountPairs(new int[] { 1, 1, 1, 1 }, 4) == 0);
```

```csharp
Debug.Assert(CountPairs(new int[] { 1, 2, 3, 4, 5 }, 5) == 10);
```
