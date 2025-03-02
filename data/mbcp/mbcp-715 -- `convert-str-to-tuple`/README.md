# mbcp-715 -- Convert string of integers to a tuple

## Text

Write a function to convert the given string of integers into a tuple.

## Code

```csharp
public Tuple<int, int> StrToTuple(string testStr)  
{  
    var res = testStr.Split(", ").Select(int.Parse).ToArray();  
    return Tuple.Create(res[0], res[1]);  
}
```

## Test List

```csharp
Debug.Assert(StrToTuple("1, -5, 4, 6, 7").Equals(Tuple.Create(1, -5, 4, 6, 7)));
```

```csharp
Debug.Assert(StrToTuple("1, 2, 3, 4, 5").Equals((1, 2, 3, 4, 5)));
```

```csharp
Debug.Assert(StrToTuple("4, 6, 9, 11, 13, 14").Equals(ValueTuple.Create(4, 6, 9, 11, 13, 14)));
```
