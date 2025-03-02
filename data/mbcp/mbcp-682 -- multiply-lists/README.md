# mbcp-682 -- Multiply two lists using map and lambda function

## Text

Write a function to multiply two lists using map and lambda function.

## Code

```csharp
public List<int> MulList(List<int> nums1, List<int> nums2)
{
    return nums1.Zip(nums2, (x, y) => x * y).ToList();
}
```

## Test List

```csharp
Debug.Assert(MulList(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }).SequenceEqual(new int[] { 4, 10, 18 }));
```

```csharp
Debug.Assert(MulList(new List<int> { 1, 2 }, new List<int> { 3, 4 }).SequenceEqual(new List<int> { 3, 8 }));
```

```csharp
Debug.Assert(MulList(new int[] { 90, 120 }, new int[] { 50, 70 }).SequenceEqual(new int[] { 4500, 8400 }));
```
