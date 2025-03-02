# mbcp512 -- Count frequencies of elements in a nested tuple

## Text

Write a function to count the element frequency in the mixed nested tuple.

## Code

```csharp
public static Dictionary<object, int> CountElementFreq(IEnumerable<object> testTuple) 
{
    var res = new Dictionary<object, int>();
    foreach (var ele in Flatten(testTuple))
    {
        if (!res.ContainsKey(ele))
        {
            res[ele] = 0;
        }
        res[ele]++;
    }
    return res;
}

private static IEnumerable<object> Flatten(IEnumerable<object> testTuple) 
{
    foreach (var tup in testTuple) 
    {
        if (tup is IEnumerable<object> subTuple) 
        {
            foreach (var item in Flatten(subTuple)) 
            {
                yield return item;
            }
        } 
        else 
        {
            yield return tup;
        }
    }
}
```

## Test List

```csharp
Debug.Assert(Flatten((5, 6, (5, 6), 7, (8, 9), 9)).SequenceEqual(new Dictionary<int, int> { { 5, 2 }, { 6, 2 }, { 7, 1 }, { 8, 1 }, { 9, 2 } }));
```

```csharp
Debug.Assert(Flatten((6, 7, (6, 7), 8, (9, 10), 10)) == new Dictionary<int, int> { { 6, 2 }, { 7, 2 }, { 8, 1 }, { 9, 1 }, { 10, 2 } });
```

```csharp
Debug.Assert(Flatten((7, 8, (7, 8), 9, (10, 11), 11)).SequenceEqual(new Dictionary<int, int> { { 7, 2 }, { 8, 2 }, { 9, 1 }, { 10, 1 }, { 11, 2 } }));
```
