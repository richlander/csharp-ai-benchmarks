# mbcp-430 -- Find the directrix of a given parabola

## Text

Write a function to find the directrix of a parabola.

## Code

```csharp
public int ParabolaDirectrix(int a, int b, int c) 
{ 
    int directrix = c - ((b * b) + 1) * 4 * a; 
    return directrix; 
}
```

## Test List

```csharp
Debug.Assert(ParabolaDirectrix(5, 3, 2) == -198);
```

```csharp
Debug.Assert(ParabolaDirectrix(9, 8, 4) == -2336);
```

```csharp
Debug.Assert(ParabolaDirectrix(2, 4, 6) == -130);
```
