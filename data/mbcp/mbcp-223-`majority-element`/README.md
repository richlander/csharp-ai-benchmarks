# mbcp223 -- Check for majority element in a sorted array

## Text

Write a function to check for majority element in the given sorted array.

## Code

```csharp
public bool IsMajority(int[] arr, int n, int x) {
    int i = BinarySearch(arr, 0, n - 1, x);
    if (i == -1) {
        return false;
    }
    if ((i + n / 2) <= (n - 1) && arr[i + n / 2] == x) {
        return true;
    } else {
        return false;
    }
}

private int BinarySearch(int[] arr, int low, int high, int x) {
    if (high >= low) {
        int mid = (low + high) / 2;
        if ((mid == 0 || x > arr[mid - 1]) && (arr[mid] == x)) {
            return mid;
        } else if (x > arr[mid]) {
            return BinarySearch(arr, mid + 1, high, x);
        } else {
            return BinarySearch(arr, low, mid - 1, x);
        }
    }
    return -1;
}
```

## Test List

```csharp
Debug.Assert(BinarySearch(new int[] { 1, 2, 3, 3, 3, 3, 10 }, 7, 3) == true);

bool BinarySearch(int[] arr, int length, int target) {
    // Implementation of the function will be here
}
```

```csharp
Debug.Assert(BinarySearch(new int[] { 1, 1, 2, 4, 4, 4, 6, 6 }, 8, 4) == false);
```

```csharp
Debug.Assert(BinarySearch(new int[] { 1, 1, 1, 2, 2 }, 5, 1) == true);
```
