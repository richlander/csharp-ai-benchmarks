# mbcp-587 -- Convert a list into a tuple using a function

## Text

Write a function to convert a list to a tuple.

## Code

```csharp
public Tuple<object> ListTuple(List<object> listx) 
{
    var tuplex = Tuple.Create(listx.ToArray());
    return tuplex;
}
```

## Test List

```csharp
Debug.Assert(ListTuple(new List<int> { 5, 10, 7, 4, 15, 3 }).Equals((5, 10, 7, 4, 15, 3)));
```

```csharp
Debug.Assert(ListTuple(new List<int> { 2, 4, 5, 6, 2, 3, 4, 4, 7 }).SequenceEqual(new ValueTuple<int, int, int, int, int, int, int, int, int>(2, 4, 5, 6, 2, 3, 4, 4, 7)));
```

```csharp
Debug.Assert(ListTuple(new int[] { 58, 44, 56 }).SequenceEqual(new int[] { 58, 44, 56 }));
```
