# mbcp842 -- Find the number that appears odd times in array

## Text

Write a function to find the number which occurs for odd number of times in the given array.

## Code

```csharp
public int GetOddOccurence(int[] arr, int arrSize) {
    for (int i = 0; i < arrSize; i++) {
        int count = 0;
        for (int j = 0; j < arrSize; j++) {
            if (arr[i] == arr[j]) {
                count++;
            }
        }
        if (count % 2 != 0) {
            return arr[i];
        }
    }
    return -1;
}
```

## Test List

```csharp
Debug.Assert(GetOddOccurence(new int[] { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 }, 13) == 5);
```

```csharp
Debug.Assert(GetOddOccurence(new int[] { 1, 2, 3, 2, 3, 1, 3 }, 7) == 3);
```

```csharp
Debug.Assert(GetOddOccurence(new int[] { 5, 7, 2, 7, 5, 2, 5 }, 7) == 5);
```
