# mbcp401 -- Add elements of two nested tuples index wise

## Text

Write a function to perform index wise addition of tuple elements in the given two nested tuples.

## Code

```csharp
Tuple<Tuple<int, int>> AddNestedTuples(Tuple<int, int>[] testTup1, Tuple<int, int>[] testTup2)  
{  
    var res = Tuple.Create(testTup1.Select((tup1, i) => Tuple.Create(tup1.Item1 + testTup2[i].Item1, tup1.Item2 + testTup2[i].Item2)).ToArray());  
    return res;  
}
```

## Test List

```csharp
Debug.Assert(AddNestedTuples(((1, 3), (4, 5), (2, 9), (1, 10)), ((6, 7), (3, 9), (1, 1), (7, 3))) == ((7, 10), (7, 14), (3, 10), (8, 13)));
```

```csharp
Debug.Assert(AddNestedTuples(((2, 4), (5, 6), (3, 10), (2, 11)), ((7, 8), (4, 10), (2, 2), (8, 4))) == ((9, 12), (9, 16), (5, 12), (10, 15)));
```

```csharp
Debug.Assert(AddNestedTuples(((3, 5), (6, 7), (4, 11), (3, 12)), ((8, 9), (5, 11), (3, 3), (9, 5))) == ((11, 14), (11, 18), (7, 14), (12, 17)));
```
