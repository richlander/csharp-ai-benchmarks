# mbcp139 -- Calculate the circumference of a circle given radius

## Text

Write a function to find the circumference of a circle.

## Code

```csharp
public double CircleCircumference(double r)  
{  
    double perimeter = 2 * 3.1415 * r;  
    return perimeter;  
}
```

## Test List

```csharp
Debug.Assert(CircleCircumference(10) == 62.830000000000005);
```

```csharp
Debug.Assert(CircleCircumference(5) == 31.415000000000003);
```

```csharp
Debug.Assert(CircleCircumference(4) == 25.132);
```
