# mbcp750 -- Add a tuple to a specified list in a function

## Text

Write a function to add the given tuple to the given list.

## Code

```csharp
public List<int> AddTuple(List<int> testList, Tuple<int, int> testTup) 
{
    testList.Add(testTup.Item1);
    testList.Add(testTup.Item2);
    return testList;
}
```

## Test List

```csharp
Debug.Assert(AddTuple(new List<int> { 5, 6, 7 }, (9, 10)).SequenceEqual(new List<int> { 5, 6, 7, 9, 10 }));
```

```csharp
Debug.Assert(AddTuple(new List<int> { 6, 7, 8 }, (10, 11)).SequenceEqual(new List<int> { 6, 7, 8, 10, 11 }));
```

```csharp
Debug.Assert(AddTuple(new List<int> { 7, 8, 9 }, Tuple.Create(11, 12)).SequenceEqual(new List<int> { 7, 8, 9, 11, 12 }));
```
