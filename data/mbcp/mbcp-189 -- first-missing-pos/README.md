# mbcp-189 -- Find the first missing positive integer in an array

## Text

Write a C# function to find the first missing positive number.

## Code

```csharp
int FirstMissingPositive(int[] arr, int n) 
{ 
    int ptr = 0; 
    for (int i = 0; i < n; i++) 
    { 
        if (arr[i] == 1) 
        { 
            ptr = 1; 
            break; 
        } 
    } 
    if (ptr == 0) 
    { 
        return 1; 
    } 
    for (int i = 0; i < n; i++) 
    { 
        if (arr[i] <= 0 || arr[i] > n) 
        { 
            arr[i] = 1; 
        } 
    } 
    for (int i = 0; i < n; i++) 
    { 
        arr[(arr[i] - 1) % n] += n; 
    } 
    for (int i = 0; i < n; i++) 
    { 
        if (arr[i] <= n) 
        { 
            return i + 1; 
        } 
    } 
    return n + 1; 
}
```

## Test List

```csharp
Debug.Assert(FirstMissingPositive(new int[] { 1, 2, 3, -1, 5 }, 5) == 4);
```

```csharp
Debug.Assert(FirstMissingPositive(new int[] { 0, -1, -2, 1, 5, 8 }, 6) == 2);
```

```csharp
Debug.Assert(FirstMissingPositive(new int[] { 0, 1, 2, 5, -8 }, 5) == 3);
```
