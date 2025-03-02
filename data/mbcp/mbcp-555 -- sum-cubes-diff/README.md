# mbcp-555 -- Difference between sum of cubes and sum of naturals

## Text

Write a C# function to find the difference between sum of cubes of first n natural numbers and the sum of first n natural numbers.

## Code

```csharp
public static long Difference(int n)  
{  
    long S = (n * (n + 1)) / 2;  
    long res = S * (S - 1);  
    return res;  
}
```

## Test List

```csharp
Debug.Assert(Difference(3) == 30);
```

```csharp
Debug.Assert(Difference(5) == 210);
```

```csharp
Debug.Assert(Difference(2) == 6);
```
