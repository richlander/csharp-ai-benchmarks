# mbcp-730 -- Remove consecutive duplicates from a list

## Text

Write a function to remove consecutive duplicates of a given list.

## Code

```csharp
public List<int> ConsecutiveDuplicates(List<int> nums) 
{
    return nums
        .Select((x, i) => new { Value = x, Index = i })
        .GroupBy(x => x.Value)
        .Select(g => g.First().Value)
        .ToList();
}
```

## Test List

```csharp
Debug.Assert(ConsecutiveDuplicates(new int[] { 0, 0, 1, 2, 3, 4, 4, 5, 6, 6, 6, 7, 8, 9, 4, 4 }) == new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 4 });

int[] ConsecutiveDuplicates(int[] numbers) {
    // Your implementation here
}
```

```csharp
Debug.Assert(ConsecutiveDuplicates(new List<int> { 10, 10, 15, 19, 18, 18, 17, 26, 26, 17, 18, 10 }).SequenceEqual(new List<int> { 10, 15, 19, 18, 17, 26, 17, 18, 10 }));
```

```csharp
Debug.Assert(ConsecutiveDuplicates(new List<string> { "a", "a", "b", "c", "d", "d" }).SequenceEqual(new List<string> { "a", "b", "c", "d" }));
```
