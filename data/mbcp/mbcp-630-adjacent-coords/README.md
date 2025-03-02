# mbcp630 -- Extract adjacent coordinates from a given tuple

## Text

Write a function to extract all the adjacent coordinates of the given coordinate tuple.

## Code

```csharp
IEnumerable<List<int>> Adjac(List<int> ele, List<int> sub = null) 
{ 
    if (sub == null) 
    {
        sub = new List<int>(); 
    }
    
    if (!ele.Any()) 
    { 
        yield return sub; 
    } 
    else 
    { 
        for (int j = ele[0] - 1; j <= ele[0] + 1; j++) 
        { 
            foreach (var idx in Adjac(ele.Skip(1).ToList(), sub.Concat(new List<int> { j }).ToList())) 
            { 
                yield return idx; 
            } 
        } 
    } 
} 

List<List<int>> GetCoordinates(List<int> testTup) 
{ 
    var res = Adjac(testTup).ToList(); 
    return res; 
}
```

## Test List

```csharp
Debug.Assert(GetCoordinates((3, 4)).SequenceEqual(new List<List<int>> { new List<int> { 2, 3 }, new List<int> { 2, 4 }, new List<int> { 2, 5 }, new List<int> { 3, 3 }, new List<int> { 3, 4 }, new List<int> { 3, 5 }, new List<int> { 4, 3 }, new List<int> { 4, 4 }, new List<int> { 4, 5 } }));
```

```csharp
Debug.Assert(GetCoordinates((4, 5)).SequenceEqual(new List<List<int>> { new List<int> { 3, 4 }, new List<int> { 3, 5 }, new List<int> { 3, 6 }, new List<int> { 4, 4 }, new List<int> { 4, 5 }, new List<int> { 4, 6 }, new List<int> { 5, 4 }, new List<int> { 5, 5 }, new List<int> { 5, 6 } }));
```

```csharp
Debug.Assert(GetCoordinates((5, 6)).SequenceEqual(new List<List<int>> { new List<int> { 4, 5 }, new List<int> { 4, 6 }, new List<int> { 4, 7 }, new List<int> { 5, 5 }, new List<int> { 5, 6 }, new List<int> { 5, 7 }, new List<int> { 6, 5 }, new List<int> { 6, 6 }, new List<int> { 6, 7 } }));
```
