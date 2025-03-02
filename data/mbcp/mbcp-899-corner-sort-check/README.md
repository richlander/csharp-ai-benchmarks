# mbcp899 -- Check if an array can be sorted using corners

## Text

Write a C# function to check whether an array can be sorted or not by picking only the corner elements.

## Code

```csharp
public bool Check(int[] arr, int n) 
{ 
    int g = 0; 
    for (int i = 1; i < n; i++) 
    { 
        if (arr[i] - arr[i - 1] > 0 && g == 1) 
        { 
            return false; 
        } 
        if (arr[i] - arr[i - 1] < 0) 
        { 
            g = 1; 
        } 
    } 
    return true; 
}
```

## Test List

```csharp
Debug.Assert(Check(new int[] { 3, 2, 1, 2, 3, 4 }, 6) == true);
```

```csharp
Debug.Assert(Check(new int[] { 2, 1, 4, 5, 1 }, 5) == true);
```

```csharp
Debug.Assert(Check(new int[] { 1, 2, 2, 1, 2, 3 }, 6) == true);
```
