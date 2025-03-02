# mbcp-739 -- Find index of smallest triangular number with n digits

## Text

Write a C# function to find the index of smallest triangular number with n digits.

## Code

```csharp
public int FindIndex(int n) 
{ 
    double x = Math.Sqrt(2 * Math.Pow(10, (n - 1))); 
    return (int)Math.Round(x); 
}
```

## Test List

```csharp
Debug.Assert(FindIndex(2) == 4);
```

```csharp
Debug.Assert(FindIndex(3) == 14);
```

```csharp
Debug.Assert(FindIndex(4) == 45);
```
