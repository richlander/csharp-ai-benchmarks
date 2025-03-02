# mbcp-445 -- Multiply elements of two tuples index by index

## Text

Write a function to perform index wise multiplication of tuple elements in the given two tuples.

## Code

```csharp
public static Tuple<Tuple<int, int>[]> IndexMultiplication(Tuple<int, int>[] testTup1, Tuple<int, int>[] testTup2)
{
    var res = testTup1.Zip(testTup2, (tup1, tup2) => 
        Tuple.Create(tup1.Item1 * tup2.Item1, tup1.Item2 * tup2.Item2)).ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(IndexMultiplication(new Tuple<int, int>[] { new Tuple<int, int>(1, 3), new Tuple<int, int>(4, 5), new Tuple<int, int>(2, 9), new Tuple<int, int>(1, 10) }, 
                                   new Tuple<int, int>[] { new Tuple<int, int>(6, 7), new Tuple<int, int>(3, 9), new Tuple<int, int>(1, 1), new Tuple<int, int>(7, 3) }) 
                  .SequenceEqual(new Tuple<int, int>[] { new Tuple<int, int>(6, 21), new Tuple<int, int>(12, 45), new Tuple<int, int>(2, 9), new Tuple<int, int>(7, 30) }));
```

```csharp
Debug.Assert(IndexMultiplication(((2, 4), (5, 6), (3, 10), (2, 11)), ((7, 8), (4, 10), (2, 2), (8, 4))) == ((14, 32), (20, 60), (6, 20), (16, 44)));
```

```csharp
Debug.Assert(IndexMultiplication(((3, 5), (6, 7), (4, 11), (3, 12)), ((8, 9), (5, 11), (3, 3), (9, 5))) == ((24, 45), (30, 77), (12, 33), (27, 60)));
```
