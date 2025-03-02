# mbcp509 -- Calculate the average of odd numbers up to n

## Text

Write a C# function to find the average of odd numbers till a given odd number.

## Code

```csharp
public static int AverageOdd(int n) 
{ 
    if (n % 2 == 0) 
    { 
        return -1; 
    } 
    
    int sm = 0; 
    int count = 0; 
    
    while (n >= 1) 
    { 
        count = count + 1; 
        sm = sm + n; 
        n = n - 2; 
    } 
    
    return sm / count; 
}
```

## Test List

```csharp
Debug.Assert(AverageOdd(9) == 5);
```

```csharp
Debug.Assert(AverageOdd(5) == 3);
```

```csharp
Debug.Assert(AverageOdd(11) == 6);
```
