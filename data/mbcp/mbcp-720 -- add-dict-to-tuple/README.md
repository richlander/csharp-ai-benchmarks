# mbcp-720 -- Add a dictionary to a tuple in a function

## Text

Write a function to add a dictionary to the tuple.

## Code

```csharp
public Tuple<object> AddDictToTuple(Tuple<object> testTup, Dictionary<string, object> testDict)
{
    var testList = testTup.ToList();
    testList.Add(testDict);
    testTup = Tuple.Create(testList.ToArray());
    return testTup;
}
```

## Test List

```csharp
Debug.Assert(AddDictToTuple((4, 5, 6), new Dictionary<string, int> { { "MSAM", 1 }, { "is", 2 }, { "best", 3 } }) == (4, 5, 6, new Dictionary<string, int> { { "MSAM", 1 }, { "is", 2 }, { "best", 3 } }));
```

```csharp
Debug.Assert(AddDictToTuple((1, 2, 3), new Dictionary<string, int> { { "UTS", 2 }, { "is", 3 }, { "Worst", 4 } }) == (1, 2, 3, new Dictionary<string, int> { { "UTS", 2 }, { "is", 3 }, { "Worst", 4 } }));
```

```csharp
Debug.Assert(AddDictToTuple((8, 9, 10), new Dictionary<string, int> { {"POS", 3}, {"is", 4}, {"Okay", 5} }) == (8, 9, 10, new Dictionary<string, int> { {"POS", 3}, {"is", 4}, {"Okay", 5} }));
```
