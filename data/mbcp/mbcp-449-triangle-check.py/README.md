# mbcp449 -- Validate triangle formation from three points

## Text

Write a C# function to check whether the triangle is valid or not if 3 points are given.

## Code

```csharp
public string CheckTriangle(double x1, double y1, double x2, double y2, double x3, double y3) 
{ 
    double a = (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)); 
    if (a == 0) 
    { 
        return "No"; 
    } 
    else 
    { 
        return "Yes"; 
    } 
}
```

## Test List

```csharp
Debug.Assert(CheckTriangle(1, 5, 2, 5, 4, 6) == "Yes");
```

```csharp
Debug.Assert(CheckTriangle(1, 1, 1, 4, 1, 5) == "No");
```

```csharp
Debug.Assert(CheckTriangle(1, 1, 1, 1, 1, 1) == "No");
```
