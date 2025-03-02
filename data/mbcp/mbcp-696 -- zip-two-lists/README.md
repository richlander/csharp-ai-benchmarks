# mbcp-696 -- Zip two lists of lists into a single list of tuples

## Text

Write a function to zip two given lists of lists.

## Code

```csharp
public List<List<T>> ZipList<T>(List<List<T>> list1, List<List<T>> list2)  
{  
    return list1.Zip(list2, (a, b) => a.Concat(b).ToList()).ToList();  
}
```

## Test List

```csharp
Debug.Assert(ZipList(new List<List<int>> { new List<int> { 1, 3 }, new List<int> { 5, 7 }, new List<int> { 9, 11 } }, 
                       new List<List<int>> { new List<int> { 2, 4 }, new List<int> { 6, 8 }, new List<int> { 10, 12, 14 } }) 
               .SequenceEqual(new List<List<int>> { new List<int> { 1, 3, 2, 4 }, new List<int> { 5, 7, 6, 8 }, new List<int> { 9, 11, 10, 12, 14 } }));
```

```csharp
Debug.Assert(ZipList(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3, 4 }, new List<int> { 5, 6 } }, new List<List<int>> { new List<int> { 7, 8 }, new List<int> { 9, 10 }, new List<int> { 11, 12 } }) == new List<List<int>> { new List<int> { 1, 2, 7, 8 }, new List<int> { 3, 4, 9, 10 }, new List<int> { 5, 6, 11, 12 } });
```

```csharp
Debug.Assert(ZipList(new List<List<string>> { new List<string> { "a", "b" }, new List<string> { "c", "d" } }, new List<List<string>> { new List<string> { "e", "f" }, new List<string> { "g", "h" } }) == new List<List<string>> { new List<string> { "a", "b", "e", "f" }, new List<string> { "c", "d", "g", "h" } });
```
