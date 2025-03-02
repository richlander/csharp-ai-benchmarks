# mbcp-751 -- Check if an array is a min heap representation

## Text

Write a function to check if the given array represents min heap or not.

## Code

```csharp
public bool CheckMinHeap(int[] arr, int i) {
    if (2 * i + 2 >= arr.Length) {
        return true;
    }
    bool leftChild = (arr[i] <= arr[2 * i + 1]) && CheckMinHeap(arr, 2 * i + 1);
    bool rightChild = (2 * i + 2 == arr.Length) || (arr[i] <= arr[2 * i + 2] && CheckMinHeap(arr, 2 * i + 2));
    return leftChild && rightChild;
}
```

## Test List

```csharp
Debug.Assert(CheckMinHeap(new int[] { 1, 2, 3, 4, 5, 6 }, 0) == true);
```

```csharp
Debug.Assert(CheckMinHeap(new int[] { 2, 3, 4, 5, 10, 15 }, 0) == true);
```

```csharp
Debug.Assert(CheckMinHeap(new int[] { 2, 10, 4, 5, 3, 15 }, 0) == false);
```
