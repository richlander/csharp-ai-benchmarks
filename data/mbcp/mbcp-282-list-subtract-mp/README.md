# mbcp282 -- Subtract two lists using map and lambda functions

## Text

Write a function to substaract two lists using map and lambda function.

## Code

```csharp
public List<int> SubList(List<int> nums1, List<int> nums2)
{
    return nums1.Zip(nums2, (x, y) => x - y).ToList();
}
```

## Test List

```csharp
Debug.Assert(SubList(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }).SequenceEqual(new int[] { -3, -3, -3 }));
```

```csharp
Debug.Assert(SubList(new List<int> { 1, 2 }, new List<int> { 3, 4 }).SequenceEqual(new List<int> { -2, -2 }));
```

```csharp
Debug.Assert(SubList(new int[] { 90, 120 }, new int[] { 50, 70 }).SequenceEqual(new int[] { 40, 50 }));
```
