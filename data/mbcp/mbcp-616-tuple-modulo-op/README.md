# mbcp616 -- Modulo operation on elements of two tuples

## Text

Write a function to perfom the modulo of tuple elements in the given two tuples.

## Code

```csharp
public static Tuple<int, int> TupleModulo(Tuple<int, int> testTup1, Tuple<int, int> testTup2) 
{
    var res = new Tuple<int, int>(testTup1.Item1 % testTup2.Item1, testTup1.Item2 % testTup2.Item2);
    return res;
}
```

## Test List

```csharp
Debug.Assert(TupleModulo((10, 4, 5, 6), (5, 6, 7, 5)).Equals((0, 4, 5, 1)));
```

```csharp
Debug.Assert(TupleModulo((11, 5, 6, 7), (6, 7, 8, 6)).Equals((5, 5, 6, 1)));
```

```csharp
Debug.Assert(TupleModulo((12, 6, 7, 8), (7, 8, 9, 7)).Equals((5, 6, 7, 1)));
```
