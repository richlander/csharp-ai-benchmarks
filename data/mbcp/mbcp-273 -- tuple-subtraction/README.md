# mbcp-273 -- Subtract corresponding tuple elements element-wise

## Text

Write a function to substract the contents of one tuple with corresponding index of other tuple.

## Code

```csharp
public Tuple<int, int> SubstractElements(Tuple<int, int> testTup1, Tuple<int, int> testTup2)
{
    return Tuple.Create(testTup1.Item1 - testTup2.Item1, testTup1.Item2 - testTup2.Item2);
}
```

## Test List

```csharp
Debug.Assert(SubstractElements(new Tuple<int, int, int>(10, 4, 5), new Tuple<int, int, int>(2, 5, 18)).Equals(new Tuple<int, int, int>(8, -1, -13)));
```

```csharp
Debug.Assert(SubstractElements(new Tuple<int, int, int>(11, 2, 3), new Tuple<int, int, int>(24, 45, 16)).Equals(new Tuple<int, int, int>(-13, -43, -13)));
```

```csharp
Debug.Assert(SubstractElements(new Tuple<int, int, int>(7, 18, 9), new Tuple<int, int, int>(10, 11, 12)).Equals(new Tuple<int, int, int>(-3, 7, -3)));
```
