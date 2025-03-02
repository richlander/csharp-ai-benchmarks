# mbcp-410 -- Find the minimum in a heterogeneous list

## Text

Write a function to find the minimum value in a given heterogeneous list.

## Code

```csharp
public int MinVal(IEnumerable<object> listval)  
{  
    int minVal = listval.OfType<int>().Min();  
    return minVal;  
}
```

## Test List

```csharp
Debug.Assert(MinVal(new object[] { "Python", 3, 2, 4, 5, "version" }) == 2);
```

```csharp
Debug.Assert(MinVal(new object[] { "Python", 15, 20, 25 }) == 15);
```

```csharp
Debug.Assert(MinVal(new object[] { "Python", 30, 20, 40, 50, "version" }) == 20);
```
