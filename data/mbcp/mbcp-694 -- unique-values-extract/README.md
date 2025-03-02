# mbcp-694 -- Extract unique values from dictionary values

## Text

Write a function to extract unique values from the given dictionary values.

## Code

```csharp
public List<string> ExtractUnique(Dictionary<string, List<string>> testDict) 
{
    var res = testDict.Values.SelectMany(val => val).Distinct().OrderBy(ele => ele).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(ExtractUnique(new Dictionary<string, List<int>> { { "msm", new List<int> { 5, 6, 7, 8 } }, { "is", new List<int> { 10, 11, 7, 5 } }, { "best", new List<int> { 6, 12, 10, 8 } }, { "for", new List<int> { 1, 2, 5 } } }) == new List<int> { 1, 2, 5, 6, 7, 8, 10, 11, 12 });
```

```csharp
Debug.Assert(ExtractUnique(new Dictionary<string, List<int>> { { "Built", new List<int> { 7, 1, 9, 4 } }, { "for", new List<int> { 11, 21, 36, 14, 9 } }, { "ISP", new List<int> { 4, 1, 21, 39, 47 } }, { "TV", new List<int> { 1, 32, 38 } } }) .SequenceEqual(new List<int> { 1, 4, 7, 9, 11, 14, 21, 32, 36, 38, 39, 47 }));
```

```csharp
Debug.Assert(ExtractUnique(new Dictionary<string, List<int>> { {"F", new List<int> {11, 13, 14, 17}}, {"A", new List<int> {12, 11, 15, 18}}, {"N", new List<int> {19, 21, 15, 36}}, {"G", new List<int> {37, 36, 35}} }) .SequenceEqual(new List<int> {11, 12, 13, 14, 15, 17, 18, 19, 21, 35, 36, 37}));
```
