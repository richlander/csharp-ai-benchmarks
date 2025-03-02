# mbcp-355 -- Count rectangles within a circle of radius r

## Text

Write a C# function to count the number of rectangles in a circle of radius r.

## Code

```csharp
public int CountRectangles(int radius)  
{  
    int rectangles = 0;  
    int diameter = 2 * radius;  
    int diameterSquare = diameter * diameter;  
    for (int a = 1; a < 2 * radius; a++)  
    {  
        for (int b = 1; b < 2 * radius; b++)  
        {  
            int diagnalLengthSquare = (a * a + b * b);  
            if (diagnalLengthSquare <= diameterSquare)  
            {  
                rectangles += 1;  
            }  
        }  
    }  
    return rectangles;  
}
```

## Test List

```csharp
Debug.Assert(CountRectangles(2) == 8);
```

```csharp
Debug.Assert(CountRectangles(1) == 1);
```

```csharp
Debug.Assert(CountRectangles(0) == 0);
```
