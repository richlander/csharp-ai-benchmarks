# mbcp358 -- Compute list modulos with map and lambda function

## Text

Write a function to find modulo division of two lists using map and lambda function.

## Code

```csharp
public List<int> ModDivList(List<int> nums1, List<int> nums2) {
    var result = nums1.Zip(nums2, (x, y) => x % y);
    return result.ToList();
}
```

## Test List

```csharp
Debug.Assert(ModDivList(new List<int> { 4, 5, 6 }, new List<int> { 1, 2, 3 }).SequenceEqual(new List<int> { 0, 1, 0 }));
```

```csharp
Debug.Assert(ModDivList(new List<int> { 3, 2 }, new List<int> { 1, 4 }).SequenceEqual(new List<int> { 0, 2 }));
```

```csharp
Debug.Assert(ModDivList(new List<int> { 90, 120 }, new List<int> { 50, 70 }).SequenceEqual(new List<int> { 40, 50 }));
```
