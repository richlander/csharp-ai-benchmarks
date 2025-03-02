# mbcp734 -- Calculate sum of products of all subarrays

## Text

Write a C# function to find sum of products of all possible subarrays.

## Code

```csharp
public long SumOfSubarrayProd(int[] arr, int n) {
    long ans = 0;
    long res = 0;
    int i = n - 1;
    while (i >= 0) {
        long incr = arr[i] * (1 + res);
        ans += incr;
        res = incr;
        i--;
    }
    return ans;
}
```

## Test List

```csharp
Debug.Assert(SumOfSubarrayProd(new int[] { 1, 2, 3 }, 3) == 20);
```

```csharp
Debug.Assert(SumOfSubarrayProd(new int[] { 1, 2 }, 2) == 5);
```

```csharp
Debug.Assert(SumOfSubarrayProd(new int[] { 1, 2, 3, 4 }, 4) == 84);
```
