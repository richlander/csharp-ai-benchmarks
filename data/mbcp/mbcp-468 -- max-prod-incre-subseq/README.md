# mbcp-468 -- Max product of increasing subsequence in array

## Text

Write a function to find the maximum product formed by multiplying numbers of an increasing subsequence of that array.

## Code

```csharp
public static int MaxProduct(int[] arr, int n) 
{ 
    int[] mpis = new int[n]; 
    for (int i = 0; i < n; i++) 
    { 
        mpis[i] = arr[i]; 
    } 
    for (int i = 1; i < n; i++) 
    { 
        for (int j = 0; j < i; j++) 
        { 
            if (arr[i] > arr[j] && mpis[i] < (mpis[j] * arr[i])) 
            { 
                mpis[i] = mpis[j] * arr[i]; 
            } 
        } 
    } 
    return mpis.Max(); 
}
```

## Test List

```csharp
Debug.Assert(MaxProduct(new int[] { 3, 100, 4, 5, 150, 6 }, 6) == 45000);
```

```csharp
Debug.Assert(MaxProduct(new int[] { 4, 42, 55, 68, 80 }) == 50265600);

public static int MaxProduct(int[] numbers)
{
    // Method implementation here
}
```

```csharp
Debug.Assert(MaxProduct(new int[] { 10, 22, 9, 33, 21, 50, 41, 60 }, 8) == 21780000);
```
