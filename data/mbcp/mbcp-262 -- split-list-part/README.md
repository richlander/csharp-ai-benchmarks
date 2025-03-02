# mbcp-262 -- Split list into two parts by specified length

## Text

Write a function to split a given list into two parts where the length of the first part of the list is given.

## Code

```csharp
public (List<T> part1, List<T> part2) SplitTwoParts<T>(List<T> list1, int L)
{
    return (list1.Take(L).ToList(), list1.Skip(L).ToList());
}
```

## Test List

```csharp
Debug.Assert(SplitTwoParts(new int[] { 1, 1, 2, 3, 4, 4, 5, 1 }, 3).Item1.SequenceEqual(new int[] { 1, 1, 2 }) && 
               SplitTwoParts(new int[] { 1, 1, 2, 3, 4, 4, 5, 1 }, 3).Item2.SequenceEqual(new int[] { 3, 4, 4, 5, 1 }));
```

```csharp
Debug.Assert(SplitTwoParts(new string[] { "a", "b", "c", "d" }, 2).Item1.SequenceEqual(new string[] { "a", "b" }) && SplitTwoParts(new string[] { "a", "b", "c", "d" }, 2).Item2.SequenceEqual(new string[] { "c", "d" }));
```

```csharp
Debug.Assert(SplitTwoParts(new char[] { 'p', 'y', 't', 'h', 'o', 'n' }, 4).Equals((new char[] { 'p', 'y', 't', 'h' }, new char[] { 'o', 'n' })));
```
