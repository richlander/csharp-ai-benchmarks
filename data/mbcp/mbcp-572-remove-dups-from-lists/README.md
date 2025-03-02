# mbcp572 -- Remove two duplicates from multiple lists in Python

## Text

Write a C# function to remove two duplicate numbers from a given number of lists.

## Code

```csharp
public List<int> TwoUniqueNums(List<int> nums)
{
    return nums.Where(i => nums.Count(x => x == i) == 1).ToList();
}
```

## Test List

```csharp
Debug.Assert(TwoUniqueNums(new int[] { 1, 2, 3, 2, 3, 4, 5 }).SequenceEqual(new int[] { 1, 4, 5 }));
```

```csharp
Debug.Assert(TwoUniqueNums(new List<int> { 1, 2, 3, 2, 4, 5 }).SequenceEqual(new List<int> { 1, 3, 4, 5 }));
```

```csharp
Debug.Assert(TwoUniqueNums(new List<int> { 1, 2, 3, 4, 5 }).SequenceEqual(new List<int> { 1, 2, 3, 4, 5 }));
```
