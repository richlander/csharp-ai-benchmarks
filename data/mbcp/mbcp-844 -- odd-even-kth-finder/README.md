# mbcp-844 -- Find the kth element in a segregated array

## Text

Write a C# function to find the kth element in an array containing odd elements first and then even elements.

## Code

```csharp
public int GetNumber(int n, int k) 
{ 
    int[] arr = new int[n]; 
    int i = 0; 
    int odd = 1; 
    while (odd <= n) 
    { 
        arr[i] = odd; 
        i++; 
        odd += 2; 
    } 
    int even = 2; 
    while (even <= n) 
    { 
        arr[i] = even; 
        i++; 
        even += 2; 
    } 
    return arr[k - 1]; 
}
```

## Test List

```csharp
Debug.Assert(GetNumber(8, 5) == 2);
```

```csharp
Debug.Assert(GetNumber(7, 2) == 3);
```

```csharp
Debug.Assert(GetNumber(5, 2) == 3);
```
