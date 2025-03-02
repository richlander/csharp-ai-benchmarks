# mbcp626 -- Find the largest triangle in a semicircle

## Text

Write a C# function to find the largest triangle that can be inscribed in the semicircle.

## Code

```csharp
public int TriangleArea(int r)  
{  
    if (r < 0)  
    {  
        return -1;  
    }  
    return r * r;  
}
```

## Test List

```csharp
Debug.Assert(TriangleArea(0) == 0);
```

```csharp
Debug.Assert(TriangleArea(-1) == -1);
```

```csharp
Debug.Assert(TriangleArea(2) == 4);

public static int TriangleArea(int baseLength) 
{
    return (baseLength * baseLength) / 2;
}
```
