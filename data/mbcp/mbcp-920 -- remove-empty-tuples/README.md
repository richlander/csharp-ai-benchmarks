# mbcp-920 -- Remove tuples with all None values from list

## Text

Write a function to remove all tuples with all none values in the given tuple list.

## Code

```csharp
public string RemoveTuple(List<Tuple<object, object>> testList)
{
    var res = testList.Where(sub => !sub.All(ele => ele == null)).ToList();
    return res.ToString();
}
```

## Test List

```csharp
Debug.Assert(RemoveTuple(new Tuple<object, object>[] { new Tuple<object, object>(null, 2), new Tuple<object, object>(null, null), new Tuple<object, object>(3, 4), new Tuple<object, object>(12, 3), new Tuple<object, object>(null, null) }).ToString() == "[(null, 2), (3, 4), (12, 3)]");
```

```csharp
Debug.Assert(RemoveTuple(new object[,] { { null, null }, { null, null }, { 3, 6 }, { 17, 3 }, { null, 1 } }) == "[(3, 6), (17, 3), (None, 1)]");
```

```csharp
Debug.Assert(RemoveTuple(new List<Tuple<int?, int?>> { Tuple.Create(1, 2), Tuple.Create(2, (int?)null), Tuple.Create(3, (int?)null), Tuple.Create(24, 3), Tuple.Create((int?)null, (int?)null) }) == "[(1, 2), (2, None), (3, None), (24, 3)]");
```
