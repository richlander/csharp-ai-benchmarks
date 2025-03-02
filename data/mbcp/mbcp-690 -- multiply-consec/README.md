# mbcp-690 -- Multiply consecutive numbers in a list with a function

## Text

Write a function to multiply consecutive numbers of a given list.

## Code

```csharp
public List<int> MulConsecutiveNums(List<int> nums) {
    List<int> result = nums.Zip(nums.Skip(1), (a, b) => b * a).ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(MulConsecutiveNums(new List<int> { 1, 1, 3, 4, 4, 5, 6, 7 }).SequenceEqual(new List<int> { 1, 3, 12, 16, 20, 30, 42 }));
```

```csharp
Debug.Assert(MulConsecutiveNums(new int[] { 4, 5, 8, 9, 6, 10 }).SequenceEqual(new int[] { 20, 40, 72, 54, 60 }));
```

```csharp
Debug.Assert(MulConsecutiveNums(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).SequenceEqual(new List<int> { 2, 6, 12, 20, 30, 42, 56, 72, 90 }));
```
