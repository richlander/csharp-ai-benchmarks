# mbcp-75 -- Find tuples where all elements are divisible by k

## Text

Write a function to find tuples which have all elements divisible by k from the given list of tuples.

## Code

```csharp
public string FindTuples(List<Tuple<int, int>> testList, int K) {
    var res = testList.Where(sub => sub.All(ele => ele % K == 0)).ToList();
    return res.ToString();
}
```

## Test List

```csharp
Debug.Assert(FindTuples(new List<Tuple<int, int, int>> { Tuple.Create(6, 24, 12), Tuple.Create(7, 9, 6), Tuple.Create(12, 18, 21) }, 6) == "[(6, 24, 12)]");
```

```csharp
Debug.Assert(FindTuples(new List<ValueTuple<int, int, int>> { (5, 25, 30), (4, 2, 3), (7, 8, 9) }, 5).ToString() == "[(5, 25, 30)]");
```

```csharp
Debug.Assert(FindTuples(new Tuple<int, int, int>[] { Tuple.Create(7, 9, 16), Tuple.Create(8, 16, 4), Tuple.Create(19, 17, 18) }, 4) == "[(8, 16, 4)]");
```
