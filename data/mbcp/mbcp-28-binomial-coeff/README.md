# mbcp28 -- Calculate binomial coefficient using Python function

## Text

Write a C# function to find binomial co-efficient.

## Code

```csharp
public int BinomialCoeff(int n, int k) 
{ 
    if (k > n) 
    { 
        return 0; 
    } 
    if (k == 0 || k == n) 
    { 
        return 1; 
    } 
    return BinomialCoeff(n - 1, k - 1) + BinomialCoeff(n - 1, k); 
}
```

## Test List

```csharp
Debug.Assert(BinomialCoeff(5, 2) == 10);
```

```csharp
Debug.Assert(BinomialCoeff(4, 3) == 4);
```

```csharp
Debug.Assert(BinomialCoeff(3, 2) == 3);
```
