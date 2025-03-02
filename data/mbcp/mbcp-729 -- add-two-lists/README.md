# mbcp-729 -- Add two lists with map and lambda functions

## Text

Write a function to add two lists using map and lambda function.

## Code

```csharp
public List<int> AddList(List<int> nums1, List<int> nums2)
{
    return nums1.Zip(nums2, (x, y) => x + y).ToList();
}
```

## Test List

```csharp
Debug.Assert(AddList(new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }).SequenceEqual(new List<int> { 5, 7, 9 }));
```

```csharp
Debug.Assert(AddList(new List<int> { 1, 2 }, new List<int> { 3, 4 }).SequenceEqual(new List<int> { 4, 6 }));
```

```csharp
Debug.Assert(AddList(new List<int> { 10, 20 }, new List<int> { 50, 70 }).SequenceEqual(new List<int> { 60, 90 }));
```
