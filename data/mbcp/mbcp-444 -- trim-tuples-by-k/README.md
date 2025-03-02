# mbcp-444 -- Trim tuples by k in a list of tuples

## Text

Write a function to trim each tuple by k in the given tuple list.

## Code

```csharp
public string TrimTuple(List<Tuple<object>> testList, int K)
{
    List<Tuple<object>> res = new List<Tuple<object>>();
    foreach (var ele in testList)
    {
        int N = ele.Item1.ToString().Length; // Assuming tuple's first item is the one we want to check
        var newTuple = new Tuple<object>(ele.Item1.ToString().Substring(K, N - 2 * K));
        res.Add(newTuple);
    }
    return res.ToString();
}
```

## Test List

```csharp
Debug.Assert(TrimTuple(new List<Tuple<int, int, int, int, int>> { 
    Tuple.Create(5, 3, 2, 1, 4), 
    Tuple.Create(3, 4, 9, 2, 1),
    Tuple.Create(9, 1, 2, 3, 5), 
    Tuple.Create(4, 8, 2, 1, 7) 
}, 2).ToString() == "[(2,), (9,), (2,), (2,)]");
```

```csharp
Debug.Assert(TrimTuple(new List<Tuple<int, int, int, int, int>> { 
    Tuple.Create(5, 3, 2, 1, 4), 
    Tuple.Create(3, 4, 9, 2, 1), 
    Tuple.Create(9, 1, 2, 3, 5), 
    Tuple.Create(4, 8, 2, 1, 7) 
}, 1) == "[(3, 2, 1), (4, 9, 2), (1, 2, 3), (8, 2, 1)]");
```

```csharp
Debug.Assert(TrimTuple(new (int, int, int, int)[] { (7, 8, 4, 9), (11, 8, 12, 4), (4, 1, 7, 8), (3, 6, 9, 7) }, 1) == "[(8, 4), (8, 12), (1, 7), (6, 9)]");
```
