# mbcp-788 -- Create a tuple from a string and a list

## Text

Write a function to create a new tuple from the given string and list.

## Code

```csharp
public static Tuple<object> NewTuple(List<object> testList, string testStr)
{
    var res = Tuple.Create(testList.Concat(new List<object> { testStr }).ToArray());
    return res;
}
```

## Test List

```csharp
Debug.Assert(NewTuple(new string[] { "WEB", "is" }, "best").SequenceEqual(new ValueTuple<string, string, string>("WEB", "is", "best")));
```

```csharp
Debug.Assert(NewTuple(new string[] { "We", "are" }, "Developers").Equals(ValueTuple.Create("We", "are", "Developers")));
```

```csharp
Debug.Assert(NewTuple(new string[] { "Part", "is" }) == Tuple.Create("Part", "is", "Wrong"));
```
