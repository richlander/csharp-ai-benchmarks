# mbcp-641 -- Find the nth nonagonal number in a sequence

## Text

Write a function to find the nth nonagonal number.

## Code

```csharp
public int IsNonagonal(int n) 
{
    return (int)(n * (7 * n - 5) / 2);
}
```

## Test List

```csharp
Debug.Assert(IsNonagonal(10) == 325);
```

```csharp
Debug.Assert(IsNonagonal(15) == 750);
```

```csharp
Debug.Assert(IsNonagonal(18) == 1089);
```
