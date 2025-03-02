# mbcp-362 -- Find the most frequent item in a list

## Text

Write a C# function to find the item with maximum occurrences in a given list.

## Code

```csharp
public int MaxOccurrences(int[] nums) {
    int maxVal = 0;
    int result = nums[0];
    foreach (int i in nums) {
        int occu = nums.Count(x => x == i);
        if (occu > maxVal) {
            maxVal = occu;
            result = i;
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(MaxOccurrences(new int[] { 1, 2, 3, 1, 2, 3, 12, 4, 2 }) == 2);
```

```csharp
Debug.Assert(MaxOccurrences(new List<int> { 1, 2, 6, 7, 0, 1, 0, 1, 0 }) == 1);
```

```csharp
Debug.Assert(MaxOccurrences(new int[] { 1, 2, 3, 1, 2, 4, 1 }) == 1);
```
