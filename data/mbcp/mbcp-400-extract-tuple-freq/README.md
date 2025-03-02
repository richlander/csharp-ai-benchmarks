# mbcp400 -- Count unique tuple frequencies in a given list

## Text

Write a function to extract the frequency of unique tuples in the given list order irrespective.

## Code

```csharp
public int ExtractFreq(List<List<int>> testList) {
    var res = testList.Select(sub => sub.OrderBy(x => x).ToArray()).Distinct().Count();
    return res;
}
```

## Test List

```csharp
Debug.Assert(ExtractFreq(new (int, int)[] { (3, 4), (1, 2), (4, 3), (5, 6) }) == 3);
```

```csharp
Debug.Assert(ExtractFreq(new (int, int)[] { (4, 15), (2, 3), (5, 4), (6, 7) }) == 4);
```

```csharp
Debug.Assert(ExtractFreq(new Tuple<int, int>[] { Tuple.Create(5, 16), Tuple.Create(2, 3), Tuple.Create(6, 5), Tuple.Create(6, 9) }) == 4);
```
