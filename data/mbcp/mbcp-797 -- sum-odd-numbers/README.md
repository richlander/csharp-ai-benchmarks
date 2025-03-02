# mbcp-797 -- Sum odd natural numbers in a given range

## Text

Write a C# function to find the sum of all odd natural numbers within the range l and r.

## Code

```csharp
public int SumOdd(int n) 
{ 
    int terms = (n + 1) / 2; 
    int sum1 = terms * terms; 
    return sum1; 
} 

public int SumInRange(int l, int r) 
{ 
    return SumOdd(r) - SumOdd(l - 1); 
}
```

## Test List

```csharp
Debug.Assert(SumInRange(2, 5) == 8);
```

```csharp
Debug.Assert(SumInRange(5, 7) == 12);
```

```csharp
Debug.Assert(SumInRange(7, 13) == 40);
```
