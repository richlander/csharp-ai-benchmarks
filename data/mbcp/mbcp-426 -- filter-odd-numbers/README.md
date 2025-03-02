# mbcp-426 -- Filter odd numbers with a lambda function

## Text

Write a function to filter odd numbers using lambda function.

## Code

```csharp
public List<int> FilterOddNumbers(List<int> nums)
{
    var oddNums = nums.Where(x => x % 2 != 0).ToList();
    return oddNums;
}
```

## Test List

```csharp
Debug.Assert(FilterOddNumbers(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).SequenceEqual(new List<int> { 1, 3, 5, 7, 9 }));
```

```csharp
Debug.Assert(FilterOddNumbers(new List<int> { 10, 20, 45, 67, 84, 93 }).SequenceEqual(new List<int> { 45, 67, 93 }));
```

```csharp
Debug.Assert(FilterOddNumbers(new int[] { 5, 7, 9, 8, 6, 4, 3 }).SequenceEqual(new int[] { 5, 7, 9, 3 }));
```
