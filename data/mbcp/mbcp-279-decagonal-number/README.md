# mbcp279 -- Find the nth decagonal number efficiently

## Text

Write a function to find the nth decagonal number.

## Code

```csharp
public int IsNumDecagonal(int n) 
{ 
    return 4 * n * n - 3 * n; 
}
```

## Test List

```csharp
Debug.Assert(IsNumDecagonal(3) == 27);
```

```csharp
Debug.Assert(IsNumDecagonal(7) == 175);
```

```csharp
Debug.Assert(IsNumDecagonal(10) == 370);
```
