# mbcp-505 -- Move all zeroes to the end of an array

## Text

Write a function to move all zeroes to the end of the given array.

## Code

```csharp
public int[] ReOrder(int[] A) {
    int k = 0;
    foreach (int i in A) {
        if (i != 0) {
            A[k] = i;
            k++;
        }
    }
    for (int i = k; i < A.Length; i++) {
        A[i] = 0;
    }
    return A;
}
```

## Test List

```csharp
Debug.Assert(ReOrder(new int[] { 6, 0, 8, 2, 3, 0, 4, 0, 1 }).SequenceEqual(new int[] { 6, 8, 2, 3, 4, 1, 0, 0, 0 }));
```

```csharp
Debug.Assert(ReOrder(new int[] { 4, 0, 2, 7, 0, 9, 0, 12, 0 }).SequenceEqual(new int[] { 4, 2, 7, 9, 12, 0, 0, 0, 0 }));
```

```csharp
Debug.Assert(ReOrder(new int[] { 3, 11, 0, 74, 14, 0, 1, 0, 2 }).SequenceEqual(new int[] { 3, 11, 74, 14, 1, 2, 0, 0, 0 }));
```
