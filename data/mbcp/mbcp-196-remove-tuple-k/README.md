# mbcp196 -- Remove tuples of length k from a list

## Text

Write a function to remove all the tuples with length k.

## Code

```csharp
public List<Tuple> RemoveTuples(List<Tuple> testList, int K) 
{
    List<Tuple> res = new List<Tuple>();
    foreach (var ele in testList)
    {
        if (ele.Item2 != K) // Assuming we're checking the length of the tuple.
        {
            res.Add(ele);
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(RemoveTuples(new List<Tuple<int, int>> { Tuple.Create(4, 5), Tuple.Create(4), Tuple.Create(8, 6, 7), Tuple.Create(1), Tuple.Create(3, 4, 6, 7) }, 1).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(4, 5), Tuple.Create(8, 6, 7), Tuple.Create(3, 4, 6, 7) }));
```

```csharp
Debug.Assert(RemoveTuples(new List<Tuple<int, int>> { Tuple.Create(4, 5), Tuple.Create(4, 5), Tuple.Create(6, 7), Tuple.Create(1, 2, 3), Tuple.Create(3, 4, 6, 7) }, 2).SequenceEqual(new List<Tuple<int, int>> { Tuple.Create(1, 2, 3), Tuple.Create(3, 4, 6, 7) }));
```

```csharp
Debug.Assert(RemoveTuples(new List<Tuple<int, int, int>> { Tuple.Create(1, 4, 4), Tuple.Create(4, 3), Tuple.Create(8, 6, 7), Tuple.Create(1), Tuple.Create(3, 6, 7) }, 3).SequenceEqual(new List<Tuple<int>> { Tuple.Create(4, 3), Tuple.Create(1) }));
```
