# mbcp-351 -- Find the first element occurring k times in array

## Text

Write a C# function to find the first element occurring k times in a given array.

## Code

```csharp
public int FirstElement(int[] arr, int n, int k) 
{ 
    Dictionary<int, int> countMap = new Dictionary<int, int>(); 
    for (int i = 0; i < n; i++) 
    { 
        if (countMap.ContainsKey(arr[i])) 
        { 
            countMap[arr[i]] += 1; 
        } 
        else 
        { 
            countMap[arr[i]] = 1; 
        } 
    } 
    for (int i = 0; i < n; i++) 
    { 
        if (countMap[arr[i]] == k) 
        { 
            return arr[i]; 
        } 
    } 
    return -1; 
}
```

## Test List

```csharp
Debug.Assert(FirstElement(new int[] { 0, 1, 2, 3, 4, 5 }, 6, 1) == 0);
```

```csharp
Debug.Assert(FirstElement(new int[] { 1, 2, 1, 3, 4 }, 5, 2) == 1);
```

```csharp
Debug.Assert(FirstElement(new int[] { 2, 3, 4, 3, 5, 7, 1, 2, 3, 5 }, 10, 2) == 2);
```
