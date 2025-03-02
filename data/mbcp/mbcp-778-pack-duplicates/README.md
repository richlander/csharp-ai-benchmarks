# mbcp778 -- Pack consecutive duplicates into sublists

## Text

Write a function to pack consecutive duplicates of a given list elements into sublists.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public List<List<T>> PackConsecutiveDuplicates<T>(List<T> list1)
{
    return list1
        .Select(g => new { Key = g, Group = list1.SkipWhile(x => !EqualityComparer<T>.Default.Equals(x, g)).TakeWhile(x => EqualityComparer<T>.Default.Equals(x, g)) })
        .Distinct()
        .Select(x => x.Group.ToList())
        .ToList();
}
```

## Test List

```csharp
Debug.Assert(PackConsecutiveDuplicates(new List<int> { 0, 0, 1, 2, 3, 4, 4, 5, 6, 6, 6, 7, 8, 9, 4, 4 }).SequenceEqual(new List<List<int>> { 
    new List<int> { 0, 0 }, 
    new List<int> { 1 }, 
    new List<int> { 2 }, 
    new List<int> { 3 }, 
    new List<int> { 4, 4 }, 
    new List<int> { 5 }, 
    new List<int> { 6, 6, 6 }, 
    new List<int> { 7 }, 
    new List<int> { 8 }, 
    new List<int> { 9 }, 
    new List<int> { 4, 4 } 
}));
```

```csharp
Debug.Assert(PackConsecutiveDuplicates(new List<int> {10, 10, 15, 19, 18, 18, 17, 26, 26, 17, 18, 10}).SequenceEqual(new List<List<int>> {new List<int> {10, 10}, new List<int> {15}, new List<int> {19}, new List<int> {18, 18}, new List<int> {17}, new List<int> {26, 26}, new List<int> {17}, new List<int> {18}, new List<int> {10}}));
```

```csharp
Debug.Assert(PackConsecutiveDuplicates(new List<string> { "a", "a", "b", "c", "d", "d" }).SequenceEqual(new List<List<string>> { new List<string> { "a", "a" }, new List<string> { "b" }, new List<string> { "c" }, new List<string> { "d", "d" } }));
```
