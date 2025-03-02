# mbcp-308 -- Find largest products from two lists

## Text

Write a function to find the specified number of largest products from two given lists.

## Code

```csharp
public List<int> LargeProduct(List<int> nums1, List<int> nums2, int N) {
    var result = nums1.SelectMany(x => nums2, (x, y) => x * y)
                      .OrderByDescending(x => x)
                      .Take(N)
                      .ToList();
    return result;
}
```

## Test List

```csharp
Debug.Assert(LargeProduct(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 3, 6, 8, 9, 10, 6 }, 3).SequenceEqual(new int[] { 60, 54, 50 }));
```

```csharp
Debug.Assert(LargeProduct(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 3, 6, 8, 9, 10, 6 }, 4).SequenceEqual(new int[] { 60, 54, 50, 48 }));
```

```csharp
Debug.Assert(LargeProduct(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 3, 6, 8, 9, 10, 6 }, 5).SequenceEqual(new int[] { 60, 54, 50, 48, 45 }));
```
