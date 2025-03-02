# mbcp-327 -- Check if a triangle is isosceles or not

## Text

Write a function to print check if the triangle is isosceles or not.

## Code

```csharp
public bool CheckIsosceles(int x, int y, int z)
{
    if (x == y || y == z || z == x)
        return true;
    else
        return false;
}
```

## Test List

```csharp
Debug.Assert(CheckIsosceles(6, 8, 12) == false);
```

```csharp
Debug.Assert(CheckIsosceles(6, 6, 12) == true);
```

```csharp
Debug.Assert(CheckIsosceles(6, 16, 20) == false);
```
