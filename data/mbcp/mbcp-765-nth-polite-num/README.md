# mbcp765 -- Find the nth polite number using a function

## Text

Write a function to find nth polite number.

## Code

```csharp
public int IsPolite(int n) 
{
    n = n + 1;
    return (int)(n + (Math.Log(n + Math.Log(n, 2), 2)));
}
```

## Test List

```csharp
Debug.Assert(IsPolite(7) == 11);
```

```csharp
Debug.Assert(IsPolite(4) == 7);
```

```csharp
Debug.Assert(IsPolite(9) == 13);
```
