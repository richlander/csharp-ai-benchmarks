# mbcp-791 -- Remove nested records from a given tuple

## Text

Write a function to remove the nested record from the given tuple.

## Code

```csharp
public static Tuple<object> RemoveNested(Tuple<object> testTup)
{
    var res = new List<object>();
    for (int count = 0; count < testTup.Item1.Length; count++)
    {
        var ele = testTup.Item1[count];
        if (!(ele is Tuple<object>))
        {
            res.Add(ele);
        }
    }
    return Tuple.Create(res.ToArray());
}
```

## Test List

```csharp
Debug.Assert(RemoveNested(new object[] { 1, 5, 7, new object[] { 4, 6 }, 10 }).SequenceEqual(new object[] { 1, 5, 7, 10 }));
```

```csharp
Debug.Assert(RemoveNested(new object[] { 2, 6, 8, new object[] { 5, 7 }, 11 }).Equals(new object[] { 2, 6, 8, 11 }));
```

```csharp
Debug.Assert(RemoveNested(new object[] { 3, 7, 9, new object[] { 6, 8 }, 12 }).Equals(new object[] { 3, 7, 9, 12 }));
```
