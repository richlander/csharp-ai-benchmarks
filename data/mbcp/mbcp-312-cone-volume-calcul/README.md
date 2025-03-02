# mbcp312 -- Calculate the volume of a cone using a function

## Text

Write a function to find the volume of a cone.

## Code

```csharp
public double VolumeCone(double r, double h)  
{  
    double volume = (1.0 / 3) * Math.PI * r * r * h;  
    return volume;  
}
```

## Test List

```csharp
Debug.Assert(VolumeCone(5, 12) == 314.15926535897927);
```

```csharp
Debug.Assert(VolumeCone(10, 15) == 1570.7963267948965);
```

```csharp
Debug.Assert(VolumeCone(19, 17) == 6426.651371693521);
```
