# mbcp-371 -- Find smallest missing element in a sorted array

## Text

Write a function to find the smallest missing element in a sorted array.

## Code

```csharp
public int SmallestMissing(int[] A, int leftElement, int rightElement) {
    if (leftElement > rightElement) {
        return leftElement;
    }
    int mid = leftElement + (rightElement - leftElement) / 2;
    if (A[mid] == mid) {
        return SmallestMissing(A, mid + 1, rightElement);
    } else {
        return SmallestMissing(A, leftElement, mid - 1);
    }
}
```

## Test List

```csharp
Debug.Assert(SmallestMissing(new int[] { 0, 1, 2, 3, 4, 5, 6 }, 0, 6) == 7);
```

```csharp
Debug.Assert(SmallestMissing(new int[] { 0, 1, 2, 6, 9, 11, 15 }, 0, 6) == 3);
```

```csharp
Debug.Assert(SmallestMissing(new int[] { 1, 2, 3, 4, 6, 9, 11, 15 }, 0, 7) == 0);
```
