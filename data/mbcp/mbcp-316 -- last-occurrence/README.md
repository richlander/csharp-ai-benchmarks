# mbcp-316 -- Find last index of a number in a sorted array

## Text

Write a function to find the index of the last occurrence of a given number in a sorted array.

## Code

```csharp
public int FindLastOccurrence(int[] A, int x) {
    int left = 0, right = A.Length - 1;
    int result = -1;
    while (left <= right) {
        int mid = (left + right) / 2;
        if (x == A[mid]) {
            result = mid;
            left = mid + 1;
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
Debug.Assert(FindLastOccurrence(new int[] { 2, 5, 5, 5, 6, 6, 8, 9, 9, 9 }, 5) == 3);
```

```csharp
Debug.Assert(FindLastOccurrence(new int[] { 2, 3, 5, 8, 6, 6, 8, 9, 9, 9 }, 9) == 9);
```

```csharp
Debug.Assert(FindLastOccurrence(new int[] { 2, 2, 1, 5, 6, 6, 6, 9, 9, 9 }, 6) == 6);
```
