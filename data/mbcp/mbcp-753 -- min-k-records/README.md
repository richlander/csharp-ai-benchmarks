# mbcp-753 -- Find minimum k records from a list of tuples

## Text

Write a function to find minimum k records from tuple list.

## Code

```csharp
public List<Tuple<int, int>> MinK(List<Tuple<int, int>> testList, int K) 
{
    var res = testList.OrderBy(x => x.Item2).Take(K).ToList();
    return res;
}
```

## Test List

```csharp
Debug.Assert(MinK(new Tuple<string, int>[] { Tuple.Create("Manjeet", 10), Tuple.Create("Akshat", 4), Tuple.Create("Akash", 2), Tuple.Create("Nikhil", 8) }, 2).SequenceEqual(new Tuple<string, int>[] { Tuple.Create("Akash", 2), Tuple.Create("Akshat", 4) }));
```

```csharp
Debug.Assert(MinK(new List<(string, int)> { ("Sanjeev", 11), ("Angat", 5), ("Akash", 3), ("Nepin", 9) }, 3).SequenceEqual(new List<(string, int)> { ("Akash", 3), ("Angat", 5), ("Nepin", 9) }));
```

```csharp
Debug.Assert(MinK(new List<Tuple<string, int>> { Tuple.Create("tanmay", 14), Tuple.Create("Amer", 11), Tuple.Create("Ayesha", 9), Tuple.Create("SKD", 16) }, 1).SequenceEqual(new List<Tuple<string, int>> { Tuple.Create("Ayesha", 9) }));
```
