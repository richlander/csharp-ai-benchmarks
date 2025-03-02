# mbcp-783 -- Convert RGB color values to HSV format

## Text

Write a function to convert rgb color to hsv color.

## Code

```csharp
public static (double h, double s, double v) RgbToHsv(int r, int g, int b)
{
    r /= 255.0;
    g /= 255.0;
    b /= 255.0;
    double mx = Math.Max(r, Math.Max(g, b));
    double mn = Math.Min(r, Math.Min(g, b));
    double df = mx - mn;
    double h, s, v;

    if (mx == mn)
    {
        h = 0;
    }
    else if (mx == r)
    {
        h = (60 * ((g - b) / df) + 360) % 360;
    }
    else if (mx == g)
    {
        h = (60 * ((b - r) / df) + 120) % 360;
    }
    else
    {
        h = (60 * ((r - g) / df) + 240) % 360;
    }

    s = mx == 0 ? 0 : (df / mx) * 100;
    v = mx * 100;

    return (h, s, v);
}
```

## Test List

```csharp
Debug.Assert(RgbToHsv(255, 255, 255).Equals((0, 0.0, 100.0)));
```

```csharp
Debug.Assert(RgbToHsv(0, 215, 0).Equals((120.0, 100.0, 84.31372549019608)));
```

```csharp
Debug.Assert(RgbToHsv(10, 215, 110).Equals((149.26829268292684, 95.34883720930233, 84.31372549019608)));
```
