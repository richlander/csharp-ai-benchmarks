# mbcp894 -- Convert a float string to a tuple format

## Text

Write a function to convert the given string of float type into tuple.

## Code

```csharp
public Tuple<float, float> FloatToTuple(string testStr) {
    var res = testStr.Split(", ").Select(float.Parse).ToArray();
    return Tuple.Create(res[0], res[1]);
}
```

## Test List

```csharp
Debug.Assert(FloatToTuple("1.2, 1.3, 2.3, 2.4, 6.5").Equals((1.2f, 1.3f, 2.3f, 2.4f, 6.5f)));
```

```csharp
Debug.Assert(FloatToTuple("2.3, 2.4, 5.6, 5.4, 8.9").Equals((2.3f, 2.4f, 5.6f, 5.4f, 8.9f)));
```

```csharp
Debug.Assert(FloatToTuple("0.3, 0.5, 7.8, 9.4").Equals((0.3f, 0.5f, 7.8f, 9.4f)));
```
