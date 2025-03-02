# mbcp845 -- Count digits in factorial of a number

## Text

Write a C# function to count the number of digits in factorial of a given number.

## Code

```csharp
public static int FindDigits(int n) 
{ 
    if (n < 0) 
        return 0; 
    if (n <= 1) 
        return 1; 
    double x = (n * Math.Log10(n / Math.E) + Math.Log10(2 * Math.PI * n) / 2.0); 
    return (int)Math.Floor(x) + 1; 
}
```

## Test List

```csharp
Debug.Assert(FindDigits(7) == 4);
```

```csharp
Debug.Assert(FindDigits(5) == 3);
```

```csharp
Debug.Assert(FindDigits(4) == 2);
```
