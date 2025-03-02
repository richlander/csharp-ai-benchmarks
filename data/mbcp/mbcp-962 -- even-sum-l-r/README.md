# mbcp-962 -- Sum even natural numbers between two ranges

## Text

Write a C# function to find the sum of all even natural numbers within the range l and r.

## Code

```csharp
public int SumNatural(int n) 
{ 
    int sum = (n * (n + 1)); 
    return sum; 
} 

public int SumEven(int l, int r) 
{ 
    return (SumNatural(r / 2) - SumNatural((l - 1) / 2)); 
}
```

## Test List

```csharp
Debug.Assert(SumEven(2, 5) == 6);
```

```csharp
Debug.Assert(SumEven(3, 8) == 18);
```

```csharp
Debug.Assert(SumEven(4, 6) == 10);
```
