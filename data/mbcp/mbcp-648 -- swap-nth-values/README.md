# mbcp-648 -- Swap every n-th and (n+1)-th list values

## Text

Write a function to exchange the position of every n-th value with (n+1)th value and (n+1)th value with n-th value in a given list.

## Code

```csharp
public List<object> ExchangeElements(List<object> lst)
{
    var lst1 = new List<object>(lst);
    var lst2 = new List<object>(lst);
    return lst.Zip(lst2.Skip(1).Take(lst.Count - 1).ToList(), (a, b) => new[] { b, a })
              .SelectMany(x => x)
              .ToList();
}
```

## Test List

```csharp
Debug.Assert(ExchangeElements(new int[] { 0, 1, 2, 3, 4, 5 }).SequenceEqual(new int[] { 1, 0, 3, 2, 5, 4 }));
```

```csharp
Debug.Assert(ExchangeElements(new List<int>{5, 6, 7, 8, 9, 10}).SequenceEqual(new List<int>{6, 5, 8, 7, 10, 9}));
```

```csharp
Debug.Assert(ExchangeElements(new int[] { 25, 35, 45, 55, 75, 95 }).SequenceEqual(new int[] { 35, 25, 55, 45, 95, 75 }));
```
