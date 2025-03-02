# mbcp963 -- Calculate the discriminant for quadratic equations

## Text

Write a function to calculate the discriminant value.

## Code

```csharp
public (string, double) DiscriminantValue(double x, double y, double z) {
    double discriminant = (y * y) - (4 * x * z);
    if (discriminant > 0) {
        return ("Two solutions", discriminant);
    } else if (discriminant == 0) {
        return ("one solution", discriminant);
    } else {
        return ("no real solution", discriminant);
    }
}
```

## Test List

```csharp
Debug.Assert(DiscriminantValue(4, 8, 2) == ("Two solutions", 32));
```

```csharp
Debug.Assert(DiscriminantValue(5, 7, 9).Equals(("no real solution", -131)));
```

```csharp
Debug.Assert(DiscriminantValue(0, 0, 9).Item1 == "one solution" && DiscriminantValue(0, 0, 9).Item2 == 0);
```
