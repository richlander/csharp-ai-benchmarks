# mbcp-294 -- Find max value in a heterogeneous list

## Text

Write a function to find the maximum value in a given heterogeneous list.

## Code

```csharp
public int MaxVal(IEnumerable<object> listval)
{
    return listval.OfType<int>().Max();
}
```

## Test List

```csharp
Debug.Assert(MaxVal(new object[] { "Python", 3, 2, 4, 5, "version" }) == 5);
```

```csharp
Debug.Assert(MaxVal(new object[] { "Python", 15, 20, 25 }) == 25);
```

```csharp
Debug.Assert(MaxVal(new object[] { "Python", 30, 20, 40, 50, "version" }) == 50);
```
