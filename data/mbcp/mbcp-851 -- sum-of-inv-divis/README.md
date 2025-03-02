# mbcp-851 -- Calculate sum of inverse of divisors in Python

## Text

Write a C# function to find sum of inverse of divisors.

## Code

```csharp
public static double SumOfInverseDivisors(int N, double Sum) 
{ 
    double ans = Sum * 1.0 / N; 
    return Math.Round(ans, 2); 
}
```

## Test List

```csharp
Debug.Assert(SumOfInverseDivisors(6, 12) == 2);
```

```csharp
Debug.Assert(SumOfInverseDivisors(9, 13) == 1.44);
```

```csharp
Debug.Assert(SumOfInverseDivisors(1, 4) == 4);
```
