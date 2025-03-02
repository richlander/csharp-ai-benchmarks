# mbcp382 -- Count rotations in a circularly sorted array

## Text

Write a function to find the number of rotations in a circularly sorted array.

## Code

```csharp
public int FindRotationCount(int[] A) {
    int left = 0, right = A.Length - 1;
    while (left <= right) {
        if (A[left] <= A[right]) {
            return left;
        }
        int mid = (left + right) / 2;
        int next = (mid + 1) % A.Length;
        int prev = (mid - 1 + A.Length) % A.Length;
        if (A[mid] <= A[next] && A[mid] <= A[prev]) {
            return mid;
        } else if (A[mid] <= A[right]) {
            right = mid - 1;
        } else if (A[mid] >= A[left]) {
            left = mid + 1;
        }
    }
    return -1;
}
```

## Test List

```csharp
Debug.Assert(FindRotationCount(new int[] { 8, 9, 10, 1, 2, 3, 4, 5, 6, 7 }) == 3);
```

```csharp
Debug.Assert(FindRotationCount(new int[] { 8, 9, 10, 2, 5, 6 }) == 3);
```

```csharp
Debug.Assert(FindRotationCount(new int[] { 2, 5, 6, 8, 9, 10 }) == 0);
```
