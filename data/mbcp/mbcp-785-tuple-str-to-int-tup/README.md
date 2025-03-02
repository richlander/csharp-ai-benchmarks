# mbcp785 -- Convert tuple string to integer tuple function

## Text

Write a function to convert tuple string to integer tuple.

## Code

```csharp
public static Tuple<int[]> TupleStrInt(string testStr) {
    var res = testStr.Replace("(", "")
                     .Replace(")", "")
                     .Replace("...", "")
                     .Split(", ")
                     .Select(num => int.Parse(num))
                     .ToArray();
    return Tuple.Create(res);
}
```

## Test List

```csharp
Debug.Assert(TupleStrInt("(7, 8, 9)").Equals(new Tuple<int, int, int>(7, 8, 9)));
```

```csharp
Debug.Assert(TupleStrInt("(1, 2, 3)").Equals(Tuple.Create(1, 2, 3)));
```

```csharp
Debug.Assert(TupleStrInt("(4, 5, 6)").Item1 == 4 && TupleStrInt("(4, 5, 6)").Item2 == 5 && TupleStrInt("(4, 5, 6)").Item3 == 6);
```
