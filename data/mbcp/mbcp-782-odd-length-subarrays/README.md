# mbcp782 -- Sum all odd-length subarrays in Python function

## Text

Write a C# function to find the sum of all odd length subarrays.

## Code

```csharp
public static int OddLengthSum(int[] arr) {
    int sum = 0;
    int l = arr.Length;
    for (int i = 0; i < l; i++) {
        sum += ((((i + 1) * (l - i) + 1) / 2) * arr[i]));
    }
    return sum;
}
```

## Test List

```csharp
Debug.Assert(Odd_Length_Sum(new int[] { 1, 2, 4 }) == 14);
```

```csharp
Debug.Assert(OddLengthSum(new int[] { 1, 2, 1, 2 }) == 15);
```

```csharp
Debug.Assert(OddLengthSum(new int[] { 1, 7 }) == 8);
```
