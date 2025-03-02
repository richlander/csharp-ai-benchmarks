# mbcp-924 -- Find the maximum of two given numbers

## Text

Write a function to find maximum of two numbers.

## Code

```csharp
public int MaxOfTwo(int x, int y) 
{
    if (x > y) 
    {
        return x;
    }
    return y;
}
```

## Test List

```csharp
Debug.Assert(MaxOfTwo(10, 20) == 20);

public int MaxOfTwo(int a, int b) {
    return a > b ? a : b;
}
```

```csharp
Debug.Assert(MaxOfTwo(19, 15) == 19);

public int MaxOfTwo(int a, int b)
{
    return (a > b) ? a : b;
}
```

```csharp
Debug.Assert(MaxOfTwo(-10, -20) == -10);
```
