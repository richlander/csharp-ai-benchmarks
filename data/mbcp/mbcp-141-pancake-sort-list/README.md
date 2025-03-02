# mbcp141 -- Pancake sort function to arrange list elements

## Text

Write a function to sort a list of elements using pancake sort.

## Code

```csharp
public List<int> PancakeSort(List<int> nums) {
    int arrLen = nums.Count;
    while (arrLen > 1) {
        int mi = nums.IndexOf(nums.Take(arrLen).Max());
        nums = nums.Take(mi + 1).Reverse().ToList().Concat(nums.Skip(mi + 1)).ToList();
        nums = nums.Take(arrLen).Reverse().ToList().Concat(nums.Skip(arrLen)).ToList();
        arrLen--;
    }
    return nums;
}
```

## Test List

```csharp
Debug.Assert(PancakeSort(new int[] { 15, 79, 25, 38, 69 }).SequenceEqual(new int[] { 15, 25, 38, 69, 79 }));
```

```csharp
Debug.Assert(PancakeSort(new int[] { 98, 12, 54, 36, 85 }).SequenceEqual(new int[] { 12, 36, 54, 85, 98 }));
```

```csharp
Debug.Assert(PancakeSort(new int[] { 41, 42, 32, 12, 23 }).SequenceEqual(new int[] { 12, 23, 32, 41, 42 }));
```
