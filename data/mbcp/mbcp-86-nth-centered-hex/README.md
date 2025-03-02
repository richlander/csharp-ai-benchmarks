# mbcp86 -- Find the nth centered hexagonal number

## Text

Write a function to find nth centered hexagonal number.

## Code

```csharp
public int CenteredHexagonalNumber(int n)  
{  
    return 3 * n * (n - 1) + 1;  
}
```

## Test List

```csharp
Debug.Assert(CenteredHexagonalNumber(10) == 271);
```

```csharp
Debug.Assert(CenteredHexagonalNumber(2) == 7);
```

```csharp
Debug.Assert(CenteredHexagonalNumber(9) == 217);
```
