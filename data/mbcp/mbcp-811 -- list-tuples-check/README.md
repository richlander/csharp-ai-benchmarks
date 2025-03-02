# mbcp-811 -- Check if two tuple lists are identical

## Text

Write a function to check if two lists of tuples are identical or not.

## Code

```csharp
public bool CheckIdentical(List<object> testList1, List<object> testList2) 
{
    bool res = testList1.SequenceEqual(testList2);
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckIdentical(new List<(int, int)>{(10, 4), (2, 5)}, new List<(int, int)>{(10, 4), (2, 5)}) == true);
```

```csharp
Debug.Assert(CheckIdentical(new List<Tuple<int, int>> { Tuple.Create(1, 2), Tuple.Create(3, 7) }, new List<Tuple<int, int>> { Tuple.Create(12, 14), Tuple.Create(12, 45) }) == false);
```

```csharp
Debug.Assert(CheckIdentical(new List<(int, int)> { (2, 14), (12, 25) }, new List<(int, int)> { (2, 14), (12, 25) }) == true);
```
