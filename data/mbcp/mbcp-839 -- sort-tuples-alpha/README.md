# mbcp-839 -- Sort tuples by the first item alphabetically

## Text

Write a function to sort the tuples alphabetically by the first item of each tuple.

## Code

```csharp
public Tuple<int, int>[] SortTuple(Tuple<int, int>[] tup) 
{ 
    int n = tup.Length; 
    for (int i = 0; i < n; i++) 
    { 
        for (int j = 0; j < n - i - 1; j++) 
        { 
            if (tup[j].Item1 > tup[j + 1].Item1) 
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
Debug.Assert(SortTuple(new Tuple<string, object>[] { Tuple.Create("Amana", 28), Tuple.Create("Zenat", 30), Tuple.Create("Abhishek", 29), Tuple.Create("Nikhil", 21), Tuple.Create("B", "C") }).SequenceEqual(new Tuple<string, object>[] { Tuple.Create("Abhishek", 29), Tuple.Create("Amana", 28), Tuple.Create("B", "C"), Tuple.Create("Nikhil", 21), Tuple.Create("Zenat", 30) }));
```

```csharp
Debug.Assert(SortTuple(new Tuple<string, object>[] { Tuple.Create("aaaa", 28), Tuple.Create("aa", 30), Tuple.Create("bab", 29), Tuple.Create("bb", 21), Tuple.Create("csa", "C") }).SequenceEqual(new List<Tuple<string, object>> { Tuple.Create("aa", 30), Tuple.Create("aaaa", 28), Tuple.Create("bab", 29), Tuple.Create("bb", 21), Tuple.Create("csa", "C") }));
```

```csharp
Debug.Assert(SortTuple(new Tuple<string, object>[] { Tuple.Create("Sarala", 28), Tuple.Create("Ayesha", 30), Tuple.Create("Suman", 29), Tuple.Create("Sai", 21), Tuple.Create("G", "H") })
                .SequenceEqual(new List<Tuple<string, object>> { Tuple.Create("Ayesha", 30), Tuple.Create("G", "H"), Tuple.Create("Sai", 21), Tuple.Create("Sarala", 28), Tuple.Create("Suman", 29) }));
```
