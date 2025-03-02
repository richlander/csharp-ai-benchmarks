# mbcp463 -- Find maximum product of a subarray in an array

## Text

Write a function to find the maximum product subarray of the given array.

## Code

```csharp
public int MaxSubarrayProduct(int[] arr) {
    int n = arr.Length;
    int maxEndingHere = 1;
    int minEndingHere = 1;
    int maxSoFar = 0;
    int flag = 0;
    
    for (int i = 0; i < n; i++) {
        if (arr[i] > 0) {
            maxEndingHere = maxEndingHere * arr[i];
            minEndingHere = Math.Min(minEndingHere * arr[i], 1);
            flag = 1;
        } else if (arr[i] == 0) {
            maxEndingHere = 1;
            minEndingHere = 1;
        } else {
            int temp = maxEndingHere;
            maxEndingHere = Math.Max(minEndingHere * arr[i], 1);
            minEndingHere = temp * arr[i];
        }
        if (maxSoFar < maxEndingHere) {
            maxSoFar = maxEndingHere;
        }
    }
    
    if (flag == 0 && maxSoFar == 0) {
        return 0;
    }
    return maxSoFar;
}
```

## Test List

```csharp
Debug.Assert(MaxSubarrayProduct(new int[] { 1, -2, -3, 0, 7, -8, -2 }) == 112);
```

```csharp
Debug.Assert(MaxSubarrayProduct(new int[] { 6, -3, -10, 0, 2 }) == 180);
```

```csharp
Debug.Assert(MaxSubarrayProduct(new int[] {-2, -40, 0, -2, -3}) == 80);
```
