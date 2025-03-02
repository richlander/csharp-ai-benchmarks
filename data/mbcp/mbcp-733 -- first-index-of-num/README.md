# mbcp-733 -- Find index of first appearance in sorted array

## Text

Write a function to find the index of the first occurrence of a given number in a sorted array.

## Code

```csharp
public int FindFirstOccurrence(int[] A, int x) {
    int left = 0, right = A.Length - 1;
    int result = -1;
    while (left <= right) {
        int mid = (left + right) / 2;
        if (x == A[mid]) {
            result = mid;
            right = mid - 1;
        } else if (x < A[mid]) {
            right = mid - 1;
        } else {
            left = mid + 1;
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(FindFirstOccurrence(new int[] { 2, 5, 5, 5, 6, 6, 8, 9, 9, 9 }, 5) == 1);
```

```csharp
Debug.Assert(FindFirstOccurrence(new int[] { 2, 3, 5, 5, 6, 6, 8, 9, 9, 9 }, 5) == 2);
```

```csharp
Debug.Assert(FindFirstOccurrence(new int[] { 2, 4, 1, 5, 6, 6, 8, 9, 9, 9 }, 6) == 4);
```
