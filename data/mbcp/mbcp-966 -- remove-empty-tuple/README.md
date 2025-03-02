# mbcp-966 -- Remove empty tuples from a list of tuples

## Text

Write a function to remove an empty tuple from a list of tuples.

## Code

```csharp
public List<Tuple<string>> RemoveEmpty(List<Tuple<string>> tuple1) // L = new List<Tuple<string>> { Tuple.Create(), Tuple.Create(), Tuple.Create(string.Empty), Tuple.Create("a", "b"), Tuple.Create("a", "b", "c"), Tuple.Create("d") }
{
    tuple1 = tuple1.Where(t => t.Item1 != null && t.Item1.Count > 0).ToList();
    return tuple1;
}
```

## Test List

```csharp
Debug.Assert(RemoveEmpty(new object[][] { new object[] { }, new object[] { }, new object[] { "" }, new object[] { "a", "b" }, new object[] { "a", "b", "c" }, new object[] { "d" } }).SequenceEqual(new object[][] { new object[] { "" }, new object[] { "a", "b" }, new object[] { "a", "b", "c" }, new object[] { "d" } }));
```

```csharp
Debug.Assert(RemoveEmpty(new object[] { new object[] { }, new object[] { }, new object[] { "" }, "python", "program" }).SequenceEqual(new object[] { new object[] { "" }, "python", "program" }));
```

```csharp
Debug.Assert(RemoveEmpty(new object[] { new Tuple<object>[] { }, new Tuple<object>[] { }, new Tuple<object>[] { "", }, "java" }).SequenceEqual(new object[] { new Tuple<object>[] { "", }, "java" }));
```
