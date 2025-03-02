# mbcp-405 -- Check if an element is in a given tuple

## Text

Write a function to check whether an element exists within a tuple.

## Code

```csharp
public bool CheckTuplex(Tuple[] tuplex, Tuple tuple1) 
{ 
    if (tuplex.Contains(tuple1)) 
    { 
        return true; 
    } 
    else 
    { 
        return false; 
    } 
}
```

## Test List

```csharp
Debug.Assert(CheckTuplex(("w", 3, "r", "e", "s", "o", "u", "r", "c", "e"), 'r') == true);
```

```csharp
Debug.Assert(CheckTuplex(("w", 3, "r", "e", "s", "o", "u", "r", "c", "e"), '5') == false);
```

```csharp
Debug.Assert(CheckTuplex(("w", 3, "r", "e", "s", "o", "u", "r", "c", "e"), 3) == true);
```
