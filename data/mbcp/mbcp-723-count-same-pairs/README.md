# mbcp723 -- Count matching pairs in two lists using map

## Text

Write a function to count the same pair in two given lists using map function.

## Code

```csharp
public int CountSamePair(List<int> nums1, List<int> nums2) {
    return nums1.Zip(nums2, (x, y) => x == y ? 1 : 0).Sum();
}
```

## Test List

```csharp
Debug.Assert(CountSamePair(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 2, 2, 3, 1, 2, 6, 7, 9 }) == 4);
```

```csharp
Debug.Assert(CountSamePair(new int[] { 0, 1, 2, -1, -5, 6, 0, -3, -2, 3, 4, 6, 8 }, new int[] { 2, 1, 2, -1, -5, 6, 4, -3, -2, 3, 4, 6, 8 }) == 11);
```

```csharp
Debug.Assert(CountSamePair(new int[] { 2, 4, -6, -9, 11, -12, 14, -5, 17 }, new int[] { 2, 1, 2, -1, -5, 6, 4, -3, -2, 3, 4, 6, 8 }) == 1);
```
