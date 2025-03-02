# mbcp183 -- Count distinct pairs with a difference of k

## Text

Write a function to count all the distinct pairs having a difference of k in any array.

## Code

```csharp
public int CountPairs(int[] arr, int n, int k) {
    int count = 0;
    for (int i = 0; i < n; i++) {
        for (int j = i + 1; j < n; j++) {
            if (arr[i] - arr[j] == k || arr[j] - arr[i] == k) {
                count++;
            }
        }
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(CountPairs(new int[] { 1, 5, 3, 4, 2 }, 5, 3) == 2);
```

```csharp
Debug.Assert(CountPairs(new int[] { 8, 12, 16, 4, 0, 20 }, 6, 4) == 5);
```

```csharp
Debug.Assert(CountPairs(new int[] { 2, 4, 1, 3, 4 }, 5, 2) == 3);
```
