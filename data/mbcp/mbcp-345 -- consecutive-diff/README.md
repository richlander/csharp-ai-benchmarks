# mbcp-345 -- Find the difference between consecutive list numbers

## Text

Write a function to find the difference between two consecutive numbers in a given list.

## Code

```csharp
public List<int> DiffConsecutiveNums(List<int> nums) {
    List<int> result = new List<int>();
    for (int i = 0; i < nums.Count - 1; i++) {
        result.Add(nums[i + 1] - nums[i]);
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(DiffConsecutiveNums(new List<int> { 1, 1, 3, 4, 4, 5, 6, 7 }).SequenceEqual(new List<int> { 0, 2, 1, 0, 1, 1, 1 }));
```

```csharp
Debug.Assert(DiffConsecutiveNums(new int[] { 4, 5, 8, 9, 6, 10 }).SequenceEqual(new int[] { 1, 3, 1, -3, 4 }));
```

```csharp
Debug.Assert(DiffConsecutiveNums(new int[] { 0, 1, 2, 3, 4, 4, 4, 4, 5, 7 }).SequenceEqual(new int[] { 1, 1, 1, 1, 0, 0, 0, 1, 2 }));
```
