# mbcp-940 -- Sort an array using the heap sort algorithm

## Text

Write a function to sort the given array by using heap sort.

## Code

```csharp
public int[] HeapSort(int[] arr) {
    Heapify(arr);
    int end = arr.Length - 1;
    while (end > 0) {
        (arr[end], arr[0]) = (arr[0], arr[end]);
        ShiftDown(arr, 0, end - 1);
        end--;
    }
    return arr;
}

private void Heapify(int[] arr) {
    int start = arr.Length / 2;
    while (start >= 0) {
        ShiftDown(arr, start, arr.Length - 1);
        start--;
    }
}

private void ShiftDown(int[] arr, int start, int end) {
    int root = start;
    while (root * 2 + 1 <= end) {
        int child = root * 2 + 1;
        if (child + 1 <= end && arr[child] < arr[child + 1]) {
            child++;
        }
        if (child <= end && arr[root] < arr[child]) {
            (arr[root], arr[child]) = (arr[child], arr[root]);
            root = child;
        } else {
            return;
        }
    }
}
```

## Test List

```csharp
Debug.Assert(HeapSort(new int[] { 12, 2, 4, 5, 2, 3 }).SequenceEqual(new int[] { 2, 2, 3, 4, 5, 12 }));
```

```csharp
Debug.Assert(HeapSort(new int[] { 32, 14, 5, 6, 7, 19 }).SequenceEqual(new int[] { 5, 6, 7, 14, 19, 32 }));
```

```csharp
Debug.Assert(HeapSort(new List<int> { 21, 15, 29, 78, 65 }).SequenceEqual(new List<int> { 15, 21, 29, 65, 78 }));
```
