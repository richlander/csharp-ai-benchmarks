# mbcp749 -- Sort a list of numeric strings in ascending order

## Text

Write a function to sort a given list of strings of numbers numerically.

## Code

```csharp
public List<int> SortNumericStrings(List<string> numsStr) {
    List<int> result = numsStr.Select(x => int.Parse(x)).ToList();
    result.Sort();
    return result;
}
```

## Test List

```csharp
Debug.Assert(SortNumericStrings(new string[] { "4", "12", "45", "7", "0", "100", "200", "-12", "-500" }).SequenceEqual(new int[] { -500, -12, 0, 4, 7, 12, 45, 100, 200 }));
```

```csharp
Debug.Assert(SortNumericStrings(new string[] { "2", "3", "8", "4", "7", "9", "8", "2", "6", "5", "1", "6", "1", "2", "3", "4", "6", "9", "1", "2" }).SequenceEqual(new int[] { 1, 1, 1, 2, 2, 2, 2, 3, 3, 4, 4, 5, 6, 6, 6, 7, 8, 8, 9, 9 }));
```

```csharp
Debug.Assert(SortNumericStrings(new List<string> { "1", "3", "5", "7", "1", "3", "13", "15", "17", "5", "7 ", "9", "1", "11" }).SequenceEqual(new List<int> { 1, 1, 1, 3, 3, 5, 5, 7, 7, 9, 11, 13, 15, 17 }));
```
