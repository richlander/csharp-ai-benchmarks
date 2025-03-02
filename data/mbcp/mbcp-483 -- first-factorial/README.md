# mbcp-483 -- Find first natural number with divisible factorial

## Text

Write a C# function to find the first natural number whose factorial is divisible by x.

## Code

```csharp
public int FirstFactorialDivisibleNumber(int x) 
{ 
    int i = 1; 
    int fact = 1; 
    for (i = 1; i < x; i++) 
    { 
        fact *= i; 
        if (fact % x == 0) 
        { 
            break; 
        } 
    } 
    return i; 
}
```

## Test List

```csharp
Debug.Assert(FirstFactorialDivisibleNumber(10) == 5);
```

```csharp
Debug.Assert(FirstFactorialDivisibleNumber(15) == 5);
```

```csharp
Debug.Assert(FirstFactorialDivisibleNumber(5) == 4);
```
