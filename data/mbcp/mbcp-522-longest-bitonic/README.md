# mbcp522 -- Find the longest bitonic subsequence in an array

## Text

Write a function to find the longest bitonic subsequence for the given array.

## Code

```csharp
public int Lbs(int[] arr) 
{ 
    int n = arr.Length; 
    int[] lis = new int[n + 1]; 
    for (int i = 0; i <= n; i++) 
    { 
        lis[i] = 1; 
    } 
    for (int i = 1; i < n; i++) 
    { 
        for (int j = 0; j < i; j++) 
        { 
            if (arr[i] > arr[j] && lis[i] < lis[j] + 1) 
            { 
                lis[i] = lis[j] + 1; 
            } 
        } 
    } 
    int[] lds = new int[n + 1]; 
    for (int i = 0; i <= n; i++) 
    { 
        lds[i] = 1; 
    } 
    for (int i = n - 2; i >= 0; i--) 
    { 
        for (int j = n - 1; j > i; j--) 
        { 
            if (arr[i] > arr[j] && lds[i] < lds[j] + 1) 
            { 
                lds[i] = lds[j] + 1; 
            } 
        } 
    } 
    int maximum = lis[0] + lds[0] - 1; 
    for (int i = 1; i < n; i++) 
    { 
        maximum = Math.Max((lis[i] + lds[i] - 1), maximum); 
    } 
    return maximum; 
}
```

## Test List

```csharp
Debug.Assert(Lbs(new int[] { 0, 8, 4, 12, 2, 10, 6, 14, 1, 9, 5, 13, 3, 11, 7, 15 }) == 7);
```

```csharp
Debug.Assert(Lbs(new List<int> { 1, 11, 2, 10, 4, 5, 2, 1 }) == 6);
```

```csharp
Debug.Assert(Lbs(new int[] { 80, 60, 30, 40, 20, 10 }) == 5);
```
