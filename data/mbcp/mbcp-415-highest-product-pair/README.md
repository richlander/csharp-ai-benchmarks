# mbcp415 -- Find the pair with the highest product in an array

## Text

Write a C# function to find a pair with highest product from a given array of integers.

## Code

```csharp
public (int, int) Max_Product(int[] arr) 
{ 
    int arr_len = arr.Length; 
    if (arr_len < 2) 
    { 
        throw new InvalidOperationException("No pairs exist"); 
    } 
    int x = arr[0]; 
    int y = arr[1]; 
    for (int i = 0; i < arr_len; i++) 
    { 
        for (int j = i + 1; j < arr_len; j++) 
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
Debug.Assert(Max_Product(new int[] { 1, 2, 3, 4, 7, 0, 8, 4 }) == (7, 8));
```

```csharp
Debug.Assert(Max_Product(new int[] { 0, -1, -2, -4, 5, 0, -6 }) == (-4, -6));
```

```csharp
Debug.Assert(Max_Product(new int[] { 1, 2, 3 }).Equals((2, 3)));
```
