# mbcp623 -- Find n-th power of list elements with lambda

## Text

Write a function to find the n-th power of individual elements in a list using lambda function.

## Code

```csharp
public List<int> NthNums(List<int> nums, int n) {
    List<int> nthNums = nums.Select(x => (int)Math.Pow(x, n)).ToList();
    return nthNums;
}
```

## Test List

```csharp
Debug.Assert(NthNums(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 2).SequenceEqual(new List<int> { 1, 4, 9, 16, 25, 36, 49, 64, 81, 100 }));
```

```csharp
Debug.Assert(NthNums(new int[] { 10, 20, 30 }, 3).SequenceEqual(new int[] { 1000, 8000, 27000 }));
```

```csharp
Debug.Assert(NthNums(new int[] { 12, 15 }, 5).SequenceEqual(new int[] { 248832, 759375 }));
```
