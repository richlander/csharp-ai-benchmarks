# mbcp-127 -- Multiply two integers without the multiplication operator

## Text

Write a function to multiply two integers without using the * operator in C#.

## Code

```csharp
public int MultiplyInt(int x, int y)
{
    if (y < 0)
    {
        return -MultiplyInt(x, -y);
    }
    else if (y == 0)
    {
        return 0;
    }
    else if (y == 1)
    {
        return x;
    }
    else
    {
        return x + MultiplyInt(x, y - 1);
    }
}
```

## Test List

```csharp
Debug.Assert(MultiplyInt(10, 20) == 200);
```

```csharp
Debug.Assert(MultiplyInt(5, 10) == 50);
```

```csharp
Debug.Assert(MultiplyInt(4, 8) == 32);
```
