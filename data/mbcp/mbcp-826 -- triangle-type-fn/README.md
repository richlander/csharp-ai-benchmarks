# mbcp-826 -- Determine triangle type from given side lengths

## Text

Write a C# function to find the type of triangle from the given sides.

## Code

```csharp
public string CheckTypeOfTriangle(double a, double b, double c) 
{
    double sqa = Math.Pow(a, 2);
    double sqb = Math.Pow(b, 2);
    double sqc = Math.Pow(c, 2);
    
    if (sqa == sqb + sqc || sqb == sqa + sqc || sqc == sqa + sqb) 
    {
        return "Right-angled Triangle";
    } 
    else if (sqa > sqb + sqc || sqb > sqa + sqc || sqc > sqa + sqb) 
    {
        return "Obtuse-angled Triangle";
    } 
    else 
    {
        return "Acute-angled Triangle";
    }
}
```

## Test List

```csharp
Debug.Assert(CheckTypeOfTriangle(1, 2, 3) == "Obtuse-angled Triangle");
```

```csharp
Debug.Assert(CheckTypeOfTriangle(2, 2, 2) == "Acute-angled Triangle");
```

```csharp
Debug.Assert(CheckTypeOfTriangle(1, 0, 1) == "Right-angled Triangle");
```
