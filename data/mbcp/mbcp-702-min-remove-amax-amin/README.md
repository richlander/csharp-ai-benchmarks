# mbcp702 -- Find minimum removals for range constraint

## Text

Write a function to find the minimum number of elements that should be removed such that amax-amin<=k.

## Code

```csharp
int FindInd(int key, int i, int n, int k, int[] arr) {
    int ind = -1;
    int start = i + 1;
    int end = n - 1;
    while (start < end) {
        int mid = start + (end - start) / 2;
        if (arr[mid] - key <= k) {
            ind = mid;
            start = mid + 1;
        } else {
            end = mid;
        }
    }
    return ind;
}

int Removals(int[] arr, int n, int k) {
    int ans = n - 1;
    Array.Sort(arr);
    for (int i = 0; i < n; i++) {
        int j = FindInd(arr[i], i, n, k, arr);
        if (j != -1) {
            ans = Math.Min(ans, n - (j - i + 1));
        }
    }
    return ans;
}
```

## Test List

```csharp
Debug.Assert(Removals(new List<int> { 1, 3, 4, 9, 10, 11, 12, 17, 20 }, 9, 4) == 5);
```

```csharp
Debug.Assert(Removals(new int[] { 1, 5, 6, 2, 8 }, 5, 2) == 3);
```

```csharp
Debug.Assert(Removals(new int[] { 1, 2, 3, 4, 5, 6 }, 6, 3) == 2);
```
