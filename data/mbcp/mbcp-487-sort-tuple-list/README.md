# mbcp487 -- Sort tuples by the last element in each tuple

## Text

Write a function to sort a list of tuples in increasing order by the last element in each tuple.

## Code

```csharp
public static Tuple<int, int>[] SortTuple(Tuple<int, int>[] tup) 
{
    int lst = tup.Length; 
    for (int i = 0; i < lst; i++) 
    {
        for (int j = 0; j < lst - i - 1; j++) 
        {
            if (tup[j].Item2 > tup[j + 1].Item2) 
            {
                var temp = tup[j]; 
                tup[j] = tup[j + 1]; 
                tup[j + 1] = temp; 
            } 
        } 
    } 
    return tup; 
}
```

## Test List

```csharp
Debug.Assert(SortTuple(new List<(int, int)> { (1, 3), (3, 2), (2, 1) }).SequenceEqual(new List<(int, int)> { (2, 1), (3, 2), (1, 3) }));
```

```csharp
Debug.Assert(SortTuple(new List<(int, int)> { (2, 4), (3, 3), (1, 1) }).SequenceEqual(new List<(int, int)> { (1, 1), (3, 3), (2, 4) }));
```

```csharp
Debug.Assert(SortTuple(new List<(int, int)> { (3, 9), (6, 7), (4, 3) }).SequenceEqual(new List<(int, int)> { (4, 3), (6, 7), (3, 9) }));
```
