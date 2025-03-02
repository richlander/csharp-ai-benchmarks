# mbcp335 -- Calculate the sum of an arithmetic sequence

## Text

Write a function to find the sum of arithmetic progression.

## Code

```csharp
public static double ApSum(double a, int n, double d)  
{  
    double total = (n * (2 * a + (n - 1) * d)) / 2;  
    return total;  
}
```

## Test List

```csharp
Debug.Assert(ApSum(1, 5, 2) == 25);
```

```csharp
Debug.Assert(ApSum(2, 6, 4) == 72);
```

```csharp
Debug.Assert(ApSum(1, 4, 5) == 34);
```
