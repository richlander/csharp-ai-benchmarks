# mbcp-112 -- Calculate the perimeter of a cylinder in Python

## Text

Write a C# function to find the perimeter of a cylinder.

## Code

```csharp
public static double Perimeter(double diameter, double height) 
{ 
    return 2 * (diameter + height); 
}
```

## Test List

```csharp
Debug.Assert(Perimeter(2, 4) == 12);
```

```csharp
Debug.Assert(Perimeter(1, 2) == 6);
```

```csharp
Debug.Assert(Perimeter(3, 1) == 8);
```
