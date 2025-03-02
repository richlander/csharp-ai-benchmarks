# mbcp948 -- Retrieve an item from a specified tuple

## Text

Write a function to get an item of a tuple.

## Code

```csharp
public object GetItem(Tuple<object, object> tup1, int index) 
{
    var item = tup1.Item1; // Adjust as necessary for tuple index
    return item;
}
```

## Test List

```csharp
Debug.Assert(GetItem(("w", 3, "r", "e", "s", "o", "u", "r", "c", "e"), 3) == 'e');
```

```csharp
Debug.Assert(GetItem(("w", 3, "r", "e", "s", "o", "u", "r", "c", "e"), -4).Equals('u'));
```

```csharp
Debug.Assert(GetItem(("w", 3, "r", "e", "s", "o", "u", "r", "c", "e"), -3) == ('r'));
```
