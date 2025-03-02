# mbcp-895 -- Find max subsequence sum without adjacent elements

## Text

Write a function to find the maximum sum of subsequences of given array with no adjacent elements.

## Code

```csharp
public static int MaxSumSubseq(int[] A) {
    int n = A.Length;
    if (n == 1) {
        return A[0];
    }
    int[] lookUp = new int[n];
    lookUp[0] = A[0];
    lookUp[1] = Math.Max(A[0], A[1]);
    for (int i = 2; i < n; i++) {
        lookUp[i] = Math.Max(lookUp[i - 1], lookUp[i - 2] + A[i]);
        lookUp[i] = Math.Max(lookUp[i], A[i]);
    }
    return lookUp[n - 1];
}
```

## Test List

```csharp
Debug.Assert(MaxSumSubseq(new int[] { 1, 2, 9, 4, 5, 0, 4, 11, 6 }) == 26);
```

```csharp
Debug.Assert(MaxSumSubseq(new int[] { 1, 2, 9, 5, 6, 0, 5, 12, 7 }) == 28);
```

```csharp
Debug.Assert(MaxSumSubseq(new int[] { 1, 3, 10, 5, 6, 0, 6, 14, 21 }) == 44);
```
