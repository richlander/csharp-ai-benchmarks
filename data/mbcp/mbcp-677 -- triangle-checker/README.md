# mbcp-677 -- Determine if a triangle is valid based on sides

## Text

Write a function to check if the triangle is valid or not.

## Code

```csharp
public bool ValidityTriangle(int a, int b, int c) 
{
    int total = a + b + c;
    return total == 180;
}
```

## Test List

```csharp
Debug.Assert(ValidityTriangle(60, 50, 90) == false);
```

```csharp
Debug.Assert(ValidityTriangle(45, 75, 60) == true);
```

```csharp
Debug.Assert(ValidityTriangle(30, 50, 100) == true);
```
