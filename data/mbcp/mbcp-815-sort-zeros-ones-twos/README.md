# mbcp815 -- Sort an array of 0s 1s and 2s without algorithms

## Text

Write a function to sort the given array without using any sorting algorithm. the given array consists of only 0, 1, and 2.

## Code

```csharp
public int[] SortByDnf(int[] arr, int n) {
    int low = 0;
    int mid = 0;
    int high = n - 1;
    while (mid <= high) {
        if (arr[mid] == 0) {
            (arr[low], arr[mid]) = (arr[mid], arr[low]);
            low++;
            mid++;
        } else if (arr[mid] == 1) {
            mid++;
        } else {
            (arr[mid], arr[high]) = (arr[high], arr[mid]);
            high--;
        }
    }
    return arr;
}
```

## Test List

```csharp
Debug.Assert(SortByDnf(new List<int> { 1, 2, 0, 1, 0, 1, 2, 1, 1 }, 9).SequenceEqual(new List<int> { 0, 0, 1, 1, 1, 1, 1, 2, 2 }));
```

```csharp
Debug.Assert(SortByDnf(new int[] { 1, 0, 0, 1, 2, 1, 2, 2, 1, 0 }, 10).SequenceEqual(new int[] { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2 }));
```

```csharp
Debug.Assert(SortByDnf(new int[] { 2, 2, 1, 0, 0, 0, 1, 1, 2, 1 }, 10).SequenceEqual(new int[] { 0, 0, 0, 1, 1, 1, 1, 2, 2, 2 }));
```
