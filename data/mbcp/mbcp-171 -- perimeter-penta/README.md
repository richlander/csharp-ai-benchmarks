# mbcp-171 -- Calculate the perimeter of a pentagon easily

## Text

Write a function to find the perimeter of a pentagon.

## Code

```csharp
public double PerimeterPentagon(double a)  
{  
    double perimeter = 5 * a;  
    return perimeter;  
}
```

## Test List

```csharp
Debug.Assert(PerimeterPentagon(5) == 25);
```

```csharp
Debug.Assert(PerimeterPentagon(10) == 50);
```

```csharp
Debug.Assert(PerimeterPentagon(15) == 75);
```
