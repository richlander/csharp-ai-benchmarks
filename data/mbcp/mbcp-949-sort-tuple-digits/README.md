# mbcp949 -- Sort a list of tuples by total digit count

## Text

Write a function to sort the given tuple list basis the total digits in tuple.

## Code

```csharp
public int CountDigs(Tuple<int>[] tup) 
{
    return tup.Sum(ele => ele.ToString().Length);
}

public string SortList(List<int> testList) 
{
    testList.Sort((x, y) => CountDigs(new Tuple<int>(x)).CompareTo(CountDigs(new Tuple<int>(y))));
    return testList.ToString();
}
```

## Test List

```csharp
Debug.Assert(SortList(new List<ValueTuple<int>> { (3, 4, 6, 723), (1, 2), (12345,), (134, 234, 34) }) == "[(1, 2), (12345,), (3, 4, 6, 723), (134, 234, 34)]");
```

```csharp
Debug.Assert(SortList(new List<Tuple<int>> { Tuple.Create(3, 4, 8), Tuple.Create(1, 2), Tuple.Create(1234335), Tuple.Create(1345, 234, 334) }) == "[(1, 2), (3, 4, 8), (1234335,), (1345, 234, 334)]");
```

```csharp
Debug.Assert(SortList(new List<ValueTuple<int, int, int, int>> { (34, 4, 61, 723), (1, 2), (145,), (134, 23) }) == "[(1, 2), (145,), (134, 23), (34, 4, 61, 723)]");
```
