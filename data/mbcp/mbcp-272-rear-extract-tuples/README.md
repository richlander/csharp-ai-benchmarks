# mbcp272 -- Extract rear elements from a list of tuples

## Text

Write a function to perfom the rear element extraction from list of tuples records.

## Code

```csharp
public List<object> RearExtract(List<List<object>> testList) 
{
    List<object> res = new List<object>();
    foreach (var lis in testList)
    {
        res.Add(lis[lis.Count - 1]);
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(RearExtract(new object[] { new Tuple<int, string, int>(1, "Rash", 21), new Tuple<int, string, int>(2, "Varsha", 20), new Tuple<int, string, int>(3, "Kil", 19) }).Equals(new int[] { 21, 20, 19 }));
```

```csharp
Debug.Assert(RearExtract(new object[,] { { 1, "Sai", 36 }, { 2, "Ayesha", 25 }, { 3, "Salman", 45 } }) == new int[] { 36, 25, 45 });
```

```csharp
Debug.Assert(RearExtract(new (int, string, int)[] { (1, "Sudeep", 14), (2, "Vandana", 36), (3, "Dawood", 56) }).SequenceEqual(new int[] { 14, 36, 56 }));
```
