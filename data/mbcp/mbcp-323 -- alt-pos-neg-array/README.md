# mbcp-323 -- Rearrange array with alternating positive and negative numbers

## Text

Write a function to re-arrange the given array in alternating positive and negative items.

## Code

```csharp
public int[] RightRotate(int[] arr, int n, int outOfPlace, int cur) {
    int temp = arr[cur];
    for (int i = cur; i > outOfPlace; i--) {
        arr[i] = arr[i - 1];
    }
    arr[outOfPlace] = temp;
    return arr;
}

public int[] ReArranage(int[] arr, int n) {
    int outOfPlace = -1;
    for (int index = 0; index < n; index++) {
        if (outOfPlace >= 0) {
            if ((arr[index] >= 0 && arr[outOfPlace] < 0) || (arr[index] < 0 && arr[outOfPlace] >= 0)) {
                arr = RightRotate(arr, n, outOfPlace, index);
                if (index - outOfPlace > 2) {
                    outOfPlace += 2;
                } else {
                    outOfPlace = -1;
                }
            }
        }
        if (outOfPlace == -1) {
            if ((arr[index] >= 0 && index % 2 == 0) || (arr[index] < 0 && index % 2 == 1)) {
                outOfPlace = index;
            }
        }
    }
    return arr;
}
```

## Test List

```csharp
Debug.Assert(ReArranage(new int[] {-5, -2, 5, 2, 4, 7, 1, 8, 0, -8}, 10).SequenceEqual(new int[] {-5, 5, -2, 2, -8, 4, 7, 1, 8, 0}));
```

```csharp
Debug.Assert(ReArranage(new int[] { 1, 2, 3, -4, -1, 4 }, 6).SequenceEqual(new int[] { -4, 1, -1, 2, 3, 4 }));
```

```csharp
Debug.Assert(ReArranage(new int[] { 4, 7, 9, 77, -4, 5, -3, -9 }, 8).SequenceEqual(new int[] { -4, 4, -3, 7, -9, 9, 77, 5 }));
```
