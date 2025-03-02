# mbcp-705 -- Sort lists by their length and values in order

## Text

Write a function to sort a list of lists by length and value.

## Code

```csharp
public List<List<T>> SortSublists(List<List<T>> list1) 
{
    list1.Sort();
    list1.Sort((a, b) => a.Count.CompareTo(b.Count));
    return list1;
}
```

## Test List

```csharp
Debug.Assert(SortSublists(new List<List<int>> { new List<int> { 2 }, new List<int> { 0 }, new List<int> { 1, 3 }, new List<int> { 0, 7 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }).SequenceEqual(new List<List<int>> { new List<int> { 0 }, new List<int> { 2 }, new List<int> { 0, 7 }, new List<int> { 1, 3 }, new List<int> { 9, 11 }, new List<int> { 13, 15, 17 } }));
```

```csharp
Debug.Assert(SortSublists(new List<List<int>> { new List<int> { 1 }, new List<int> { 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7 }, new List<int> { 10, 11 } }).SequenceEqual(new List<List<int>> { new List<int> { 1 }, new List<int> { 7 }, new List<int> { 2, 3 }, new List<int> { 10, 11 }, new List<int> { 4, 5, 6 } }));
```

```csharp
Debug.Assert(SortSublists(new List<List<string>> { new List<string> { "python" }, new List<string> { "java", "C", "C++" }, new List<string> { "DBMS" }, new List<string> { "SQL", "HTML" } })
    .SequenceEqual(new List<List<string>> { new List<string> { "DBMS" }, new List<string> { "python" }, new List<string> { "SQL", "HTML" }, new List<string> { "java", "C", "C++" } }));
```
