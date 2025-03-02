# mbcp-970 -- Function to determine the smaller of two numbers

## Text

Write a function to find minimum of two numbers.

## Code

```csharp
public static int MinOfTwo(int x, int y)  
{  
    if (x < y)  
    {  
        return x;  
    }  
    return y;  
}
```

## Test List

```csharp
Debug.Assert(MinOfTwo(10, 20) == 10);

int MinOfTwo(int a, int b) 
{
    return (a < b) ? a : b;
}
```

```csharp
Debug.Assert(MinOfTwo(19, 15) == 15);
```

```csharp
Debug.Assert(MinOfTwo(-10, -20) == -20);

public int MinOfTwo(int a, int b)
{
    return a < b ? a : b;
}
```
