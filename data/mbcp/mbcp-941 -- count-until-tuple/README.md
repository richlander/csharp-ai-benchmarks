# mbcp-941 -- Count list elements until a tuple is found

## Text

Write a function to count the elements in a list until an element is a tuple.

## Code

```csharp
public int CountElim(IEnumerable<object> num)
{
    int countElim = 0;
    foreach (var n in num)
    {
        if (n is Tuple)
        {
            break;
        }
        countElim++;
    }
    return countElim;
}
```

## Test List

```csharp
Debug.Assert(CountElim(new object[] { 10, 20, 30, Tuple.Create(10, 20), 40 }) == 3);
```

```csharp
Debug.Assert(CountElim(new object[] { 10, new Tuple<int, int>(20, 30), new Tuple<int, int>(10, 20), 40 }) == 1);
```

```csharp
Debug.Assert(CountElim(new List<Tuple<int, Tuple<int, int, Tuple<int, int>, int>>> { Tuple.Create(10, Tuple.Create(20, 30, Tuple.Create(10, 20), 40) ) }) == 0);
```
