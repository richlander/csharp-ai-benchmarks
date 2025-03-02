# mbcp664 -- Calculate average of even numbers up to n

## Text

Write a C# function to find the average of even numbers till a given even number.

## Code

```csharp
public static string AverageEven(int n) 
{ 
    if (n % 2 != 0) 
    { 
        return "Invalid Input"; 
    } 
    
    int sm = 0; 
    int count = 0; 
    
    while (n >= 2) 
    { 
        count++; 
        sm += n; 
        n -= 2; 
    } 
    
    return (sm / count).ToString(); 
}
```

## Test List

```csharp
Debug.Assert(AverageEven(2) == 2);
```

```csharp
Debug.Assert(AverageEven(4) == 3);
```

```csharp
Debug.Assert(AverageEven(100) == 51);
```
