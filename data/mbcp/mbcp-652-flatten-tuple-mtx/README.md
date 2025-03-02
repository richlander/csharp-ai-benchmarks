# mbcp652 -- Flatten a tuple matrix into a list of columns

## Text

Write a function to flatten the given tuple matrix into the tuple list with each tuple representing each column.

## Code

```csharp
public string MatrixToList(List<List<object>> testList)
{
    var temp = testList.SelectMany(sub => sub).ToList();
    var res = Enumerable.Zip(temp.Select((x, i) => new { Value = x, Index = i }), 
                              temp.Select((x, i) => new { Value = x, Index = i }), 
                              (a, b) => new { a.Value, b.Value }).ToList();
    return res.ToString();
}
```

## Test List

```csharp
Debug.Assert(MatrixToList(new (int, int)[][][] { new (int, int)[] { (4, 5), (7, 8) }, new (int, int)[] { (10, 13), (18, 17) }, new (int, int)[] { (0, 4), (10, 1) } }) == "[(4, 7, 10, 18, 0, 10), (5, 8, 13, 17, 4, 1)]");
```

```csharp
Debug.Assert(MatrixToList(new List<List<(int, int)>> { new List<(int, int)> { (5, 6), (8, 9) }, new List<(int, int)> { (11, 14), (19, 18) }, new List<(int, int)> { (1, 5), (11, 2) } }) == "[(5, 8, 11, 19, 1, 11), (6, 9, 14, 18, 5, 2)]");
```

```csharp
Debug.Assert(MatrixToList(new List<List<(int, int)>> { new List<(int, int)> { (6, 7), (9, 10) }, new List<(int, int)> { (12, 15), (20, 21) }, new List<(int, int)> { (23, 7), (15, 8) } }) == "[(6, 9, 12, 20, 23, 15), (7, 10, 15, 21, 7, 8)]");
```
