# mbcp-368 -- Repeat a tuple n times with a function

## Text

Write a function to repeat the given tuple n times.

## Code

```csharp
public static Tuple<T>[] RepeatTuples<T>(Tuple<T> testTup, int N)
{
    var res = Enumerable.Repeat(testTup, N).ToArray();
    return res;
}
```

## Test List

```csharp
Debug.Assert(RepeatTuples((1, 3), 4).SequenceEqual(new[] { (1, 3), (1, 3), (1, 3), (1, 3) }));
```

```csharp
Debug.Assert(RepeatTuples((1, 2), 3).SequenceEqual(new[] { (1, 2), (1, 2), (1, 2) }));
```

```csharp
Debug.Assert(RepeatTuples((3, 4), 5).SequenceEqual(new[] { (3, 4), (3, 4), (3, 4), (3, 4), (3, 4) }));
```
