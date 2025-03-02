# mbcp527 -- Find pairs in array with sum equal to target number

## Text

Write a function to find all pairs in an integer array whose sum is equal to a given number.

## Code

```csharp
public int GetPairsCount(int[] arr, int n, int sum) {
    int count = 0; 
    for (int i = 0; i < n; i++) {
        for (int j = i + 1; j < n; j++) {
            if (arr[i] + arr[j] == sum) {
                count++;
            }
        }
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(GetPairsCount(new List<int> { 1, 5, 7, -1, 5 }, 5, 6) == 3);
```

```csharp
Debug.Assert(GetPairsCount(new int[] { 1, 5, 7, -1 }, 4, 6) == 2);
```

```csharp
Debug.Assert(GetPairsCount(new int[] { 1, 1, 1, 1 }, 4, 2) == 6);
```
