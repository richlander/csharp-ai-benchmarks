# mbcp-438 -- Count unique bidirectional tuple pairs in a function

## Text

Write a function to count bidirectional tuple pairs.

## Code

```csharp
public string CountBidirectional(List<Tuple<int, int>> testList) {
    int res = 0;
    for (int idx = 0; idx < testList.Count; idx++) {
        for (int iidx = idx + 1; iidx < testList.Count; iidx++) {
            if (testList[iidx].Item1 == testList[idx].Item2 && testList[idx].Item2 == testList[iidx].Item1) {
                res++;
            }
        }
    }
    return res.ToString();
}
```

## Test List

```csharp
Debug.Assert(CountBidirectional(new Tuple<int, int>[] { Tuple.Create(5, 6), Tuple.Create(1, 2), Tuple.Create(6, 5), Tuple.Create(9, 1), Tuple.Create(6, 5), Tuple.Create(2, 1) }) == "3");
```

```csharp
Debug.Assert(CountBidirectional(new Tuple<int, int>[] { Tuple.Create(5, 6), Tuple.Create(1, 3), Tuple.Create(6, 5), Tuple.Create(9, 1), Tuple.Create(6, 5), Tuple.Create(2, 1) }) == "2");
```

```csharp
Debug.Assert(CountBidirectional(new (int, int)[] { (5, 6), (1, 2), (6, 5), (9, 2), (6, 5), (2, 1) }) == '4');
```
