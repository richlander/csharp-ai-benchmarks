# mbcp156 -- Convert string tuple to integer tuple

## Text

Write a function to convert a tuple of string values to a tuple of integer values.

## Code

```csharp
public static (int, int)[] TupleIntStr((string, string)[] tupleStr) {
    var result = tupleStr.Select(x => (int.Parse(x.Item1), int.Parse(x.Item2))).ToArray();
    return result;
}
```

## Test List

```csharp
Debug.Assert(TupleIntStr(new Tuple<string, string>[] { new Tuple<string, string>("333", "33"), new Tuple<string, string>("1416", "55") }).Equals(new Tuple<int, int>[] { new Tuple<int, int>(333, 33), new Tuple<int, int>(1416, 55) }));
```

```csharp
Debug.Assert(TupleIntStr((new Tuple<string, string>("999", "99"), new Tuple<string, string>("1000", "500"))) == (new Tuple<int, int>(999, 99), new Tuple<int, int>(1000, 500)));
```

```csharp
Debug.Assert(TupleIntStr((("666", "66"), ("1500", "555"))) == ((666, 66), (1500, 555)));
```
