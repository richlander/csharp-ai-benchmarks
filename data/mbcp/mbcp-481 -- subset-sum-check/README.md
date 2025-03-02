# mbcp-481 -- Subset sum problem: find if subset matches sum

## Text

Write a function to determine if there is a subset of the given set with sum equal to the given sum.

## Code

```csharp
bool IsSubsetSum(int[] set, int n, int sum) {
    if (sum == 0) {
        return true;
    }
    if (n == 0) {
        return false;
    }
    if (set[n - 1] > sum) {
        return IsSubsetSum(set, n - 1, sum);
    }
    return IsSubsetSum(set, n - 1, sum) || IsSubsetSum(set, n - 1, sum - set[n - 1]);
}
```

## Test List

```csharp
Debug.Assert(IsSubsetSum(new int[] { 3, 34, 4, 12, 5, 2 }, 6, 9) == true);
```

```csharp
Debug.Assert(IsSubsetSum(new int[] { 3, 34, 4, 12, 5, 2 }, 6, 30) == false);
```

```csharp
Debug.Assert(IsSubsetSum(new int[] { 3, 34, 4, 12, 5, 2 }, 6, 15) == true);
```
