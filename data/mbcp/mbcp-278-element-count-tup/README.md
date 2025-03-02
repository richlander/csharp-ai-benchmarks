# mbcp278 -- Count elements before record in a tuple

## Text

Write a function to find the element count that occurs before the record in the given tuple.

## Code

```csharp
public static int CountFirstElements(Tuple[] testTup)
{
    int count = 0;
    foreach (var ele in testTup.Select((value, index) => new { value, index }))
    {
        count = ele.index;
        if (ele.value is Tuple)
        {
            break;
        }
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(CountFirstElements(new object[] { 1, 5, 7, new object[] { 4, 6 }, 10 }) == 3);
```

```csharp
Debug.Assert(CountFirstElements(new object[] { 2, 9, new object[] { 5, 7 }, 11 }) == 2);
```

```csharp
Debug.Assert(CountFirstElements(new object[] { 11, 15, 5, 8, new object[] { 2, 3 }, 8 }) == 4);
```
