# mbcp-766 -- Iterate over consecutive item pairs in a list

## Text

Write a function to iterate over all pairs of consecutive items in a given list.

## Code

```csharp
public List<(T, T)> PairWise<T>(List<T> l1)
{
    var temp = new List<(T, T)>();
    for (int i = 0; i < l1.Count - 1; i++)
    {
        var currentElement = l1[i];
        var nextElement = l1[i + 1];
        var x = (currentElement, nextElement);
        temp.Add(x);
    }
    return temp;
}
```

## Test List

```csharp
Debug.Assert(PairWise(new List<int> { 1, 1, 2, 3, 3, 4, 4, 5 }).SequenceEqual(new List<(int, int)> { (1, 1), (1, 2), (2, 3), (3, 3), (3, 4), (4, 4), (4, 5) }));
```

```csharp
Debug.Assert(PairWise(new List<int> { 1, 5, 7, 9, 10 }).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(1, 5), Tuple.Create(5, 7), Tuple.Create(7, 9), Tuple.Create(9, 10) }));
```

```csharp
Debug.Assert(PairWise(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }).SequenceEqual(new Tuple<int, int>[] { 
    Tuple.Create(1, 2), Tuple.Create(2, 3), Tuple.Create(3, 4), 
    Tuple.Create(4, 5), Tuple.Create(5, 6), Tuple.Create(6, 7), 
    Tuple.Create(7, 8), Tuple.Create(8, 9), Tuple.Create(9, 10) }));
```
