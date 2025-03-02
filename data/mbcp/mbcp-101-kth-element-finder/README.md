# mbcp101 -- Find the kth element in an array

## Text

Write a function to find the kth element in the given array.

## Code

```csharp
public int KthElement(int[] arr, int n, int k) {
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n - i - 1; j++) {
            if (arr[j] > arr[j + 1]) {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    return arr[k - 1];
}
```

## Test List

```csharp
Debug.Assert(KthElement(new int[] { 12, 3, 5, 7, 19 }, 5, 2) == 3);
```

```csharp
Debug.Assert(KthElement(new int[] { 17, 24, 8, 23 }, 4, 3) == 8);
```

```csharp
Debug.Assert(KthElement(new int[] { 16, 21, 25, 36, 4 }, 5, 4) == 36);
```
