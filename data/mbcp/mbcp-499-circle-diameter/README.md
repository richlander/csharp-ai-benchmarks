# mbcp499 -- Calculate the diameter of a circle from its radius

## Text

Write a function to find the diameter of a circle.

## Code

```csharp
public double DiameterCircle(double r)  
{  
    double diameter = 2 * r;  
    return diameter;  
}
```

## Test List

```csharp
Debug.Assert(DiameterCircle(10) == 20);
```

```csharp
Debug.Assert(DiameterCircle(40) == 80);
```

```csharp
Debug.Assert(DiameterCircle(15) == 30);
```
