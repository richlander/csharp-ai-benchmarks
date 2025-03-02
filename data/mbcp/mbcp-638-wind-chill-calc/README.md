# mbcp638 -- Calculate wind chill index based on temperature and wind

## Text

Write a function to calculate wind chill index.

## Code

```csharp
public int WindChill(double v, double t)  
{  
    double windchill = 13.12 + 0.6215 * t - 11.37 * Math.Pow(v, 0.16) + 0.3965 * t * Math.Pow(v, 0.16);  
    return (int)Math.Round(windchill, 0);  
}
```

## Test List

```csharp
Debug.Assert(WindChill(120, 35) == 40);
```

```csharp
Debug.Assert(WindChill(40, 70) == 86);
```

```csharp
Debug.Assert(WindChill(10, 100) == 116);
```
