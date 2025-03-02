# mbcp-929 -- Count repeated items in a tuple

## Text

Write a function to count repeated items of a tuple.

## Code

```csharp
public int CountTuplex(Tuple<int, int>[] tuplex, int value)  
{  
    int count = tuplex.Count(t => t.Item1 == value || t.Item2 == value);  
    return count;  
}
```

## Test List

```csharp
Debug.Assert(CountTuplex(new Tuple<int, int, int, int, int, int, int, int, int>(2, 4, 5, 6, 2, 3, 4, 4, 7), 4) == 3);
```

```csharp
Debug.Assert(CountTuplex(new Tuple<int, int, int, int, int, int, int, int, int>(2, 4, 5, 6, 2, 3, 4, 4, 7), 2) == 2);
```

```csharp
Debug.Assert(CountTuplex(new Tuple<int, int, int, int, int, int, int, int, int>(2, 4, 7, 7, 7, 3, 4, 4, 7), 7) == 4);
```
