# mbcp158 -- Find operations to equalize array elements

## Text

Write a C# function to find k number of operations required to make all elements equal.

## Code

```csharp
public static int MinOps(int[] arr, int n, int k) 
{ 
    int max1 = arr.Max(); 
    int res = 0; 
    for (int i = 0; i < n; i++) 
    { 
        if ((max1 - arr[i]) % k != 0) 
        { 
            return -1; 
        } 
        else 
        { 
            res += (max1 - arr[i]) / k; 
        } 
    } 
    return res; 
}
```

## Test List

```csharp
Debug.Assert(MinOps(new int[] { 2, 2, 2, 2 }, 4, 3) == 0);
```

```csharp
Debug.Assert(MinOps(new int[] { 4, 2, 6, 8 }, 4, 3) == -1);
```

```csharp
Debug.Assert(MinOps(new int[] { 21, 33, 9, 45, 63 }, 5, 6) == 24);
```
