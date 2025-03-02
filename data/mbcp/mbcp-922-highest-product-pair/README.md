# mbcp922 -- Find the pair with the highest product in an array

## Text

Write a function to find a pair with the highest product from a given array of integers.

## Code

```csharp
public (int, int)? MaxProduct(int[] arr) 
{ 
    int arrLen = arr.Length; 
    if (arrLen < 2) 
    { 
        return null; 
    } 
    int x = arr[0]; 
    int y = arr[1]; 
    for (int i = 0; i < arrLen; i++) 
    { 
        for (int j = i + 1; j < arrLen; j++) 
        { 
            if (arr[i] * arr[j] > x * y) 
            { 
                x = arr[i]; 
                y = arr[j]; 
            } 
        } 
    } 
    return (x, y); 
}
```

## Test List

```csharp
Debug.Assert(MaxProduct(new int[] { 1, 2, 3, 4, 7, 0, 8, 4 }) == (7, 8));
```

```csharp
Debug.Assert(MaxProduct(new int[] { 0, -1, -2, -4, 5, 0, -6 }).Equals((-4, -6)));

public static (int, int) MaxProduct(int[] nums)
{
    // Method implementation goes here
}
```

```csharp
Debug.Assert(MaxProduct(new int[] { 1, 3, 5, 6, 8, 9 }) == (8, 9));
```
