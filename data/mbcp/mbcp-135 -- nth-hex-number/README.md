# mbcp-135 -- Find the nth hexagonal number efficiently

## Text

Write a function to find the nth hexagonal number.

## Code

```csharp
public static int HexagonalNum(int n) 
{
    return n * (2 * n - 1);
}
```

## Test List

```csharp
Debug.Assert(HexagonalNum(10) == 190);
```

```csharp
Debug.Assert(HexagonalNum(5) == 45);
```

```csharp
Debug.Assert(HexagonalNum(7) == 91);
```
