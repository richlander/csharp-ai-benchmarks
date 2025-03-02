# mbcp518 -- Find the square root of a perfect number

## Text

Write a function to find the square root of a perfect number.

## Code

```csharp
public double SqrtRoot(double num)
{
    double sqrtRoot = Math.Pow(num, 0.5);
    return sqrtRoot;
}
```

## Test List

```csharp
Debug.Assert(SqrtRoot(4) == 2);
```

```csharp
Debug.Assert(SqrtRoot(16) == 4);
```

```csharp
Debug.Assert(SqrtRoot(400) == 20);
```
