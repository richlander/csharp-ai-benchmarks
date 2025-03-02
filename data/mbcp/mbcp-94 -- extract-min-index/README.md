# mbcp-94 -- Extract minimum index value from given tuples

## Text

Write a function to extract the index minimum value record from the given tuples.

## Code

```csharp
public static T indexMinimum<T>(List<Tuple<T, int>> testList)
{
    var res = testList.OrderBy(x => x.Item2).First().Item1;
    return res;
}
```

## Test List

```csharp
Debug.Assert(index_minimum(new Tuple<string, int>[] { Tuple.Create("Rash", 143), Tuple.Create("Manjeet", 200), Tuple.Create("Varsha", 100) }) == "Varsha");
```

```csharp
Debug.Assert(index_minimum(new Tuple<string, int>[] { Tuple.Create("Yash", 185), Tuple.Create("Dawood", 125), Tuple.Create("Sanya", 175) }) == "Dawood");
```

```csharp
Debug.Assert(index_minimum(new Tuple<string, int>[] { Tuple.Create("Sai", 345), Tuple.Create("Salman", 145), Tuple.Create("Ayesha", 96) }) == "Ayesha");
```
