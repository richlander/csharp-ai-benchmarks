# mbcp381 -- Sort a list of lists by a specified inner index

## Text

Write a function to sort a list of lists by a given index of the inner list.

## Code

```csharp
public List<List<T>> IndexOnInnerList<T>(List<List<T>> listData, int indexNo)
{
    return listData.OrderBy(item => item[indexNo]).ToList();
}
```

## Test List

```csharp
Debug.Assert(IndexOnInnerList(new List<Tuple<string, int, int>> { 
    Tuple.Create("Greyson Fulton", 98, 99), 
    Tuple.Create("Brady Kent", 97, 96), 
    Tuple.Create("Wyatt Knott", 91, 94), 
    Tuple.Create("Beau Turnbull", 94, 98) }, 0).SequenceEqual(new List<Tuple<string, int, int>> { 
    Tuple.Create("Beau Turnbull", 94, 98), 
    Tuple.Create("Brady Kent", 97, 96), 
    Tuple.Create("Greyson Fulton", 98, 99), 
    Tuple.Create("Wyatt Knott", 91, 94) }));
```

```csharp
Debug.Assert(IndexOnInnerList(new (string, int, int)[] { 
    ("Greyson Fulton", 98, 99), 
    ("Brady Kent", 97, 96), 
    ("Wyatt Knott", 91, 94), 
    ("Beau Turnbull", 94, 98) }, 1).SequenceEqual(new (string, int, int)[] { 
    ("Wyatt Knott", 91, 94), 
    ("Beau Turnbull", 94, 98), 
    ("Brady Kent", 97, 96), 
    ("Greyson Fulton", 98, 99) }));
```

```csharp
Debug.Assert(IndexOnInnerList(new Tuple<string, int, int>[] { Tuple.Create("Greyson Fulton", 98, 99), Tuple.Create("Brady Kent", 97, 96), Tuple.Create("Wyatt Knott", 91, 94), Tuple.Create("Beau Turnbull", 94, 98) }, 2).SequenceEqual(new Tuple<string, int, int>[] { Tuple.Create("Wyatt Knott", 91, 94), Tuple.Create("Brady Kent", 97, 96), Tuple.Create("Beau Turnbull", 94, 98), Tuple.Create("Greyson Fulton", 98, 99) }));
```
