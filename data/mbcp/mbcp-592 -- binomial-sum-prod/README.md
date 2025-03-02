# mbcp-592 -- Calculate sum of products of binomial coefficients

## Text

Write a C# function to find sum of product of binomial co-efficients.

## Code

```csharp
public static int BinomialCoeff(int n, int k) 
{ 
    int[] C = new int[k + 1]; 
    C[0] = 1; 
    for (int i = 1; i <= n; i++) 
    { 
        for (int j = Math.Min(i, k); j > 0; j--) 
        { 
            C[j] += C[j - 1]; 
        } 
    } 
    return C[k]; 
}

public static int SumOfProduct(int n) 
{ 
    return BinomialCoeff(2 * n, n - 1); 
}
```

## Test List

```csharp
Debug.Assert(SumOfProduct(3) == 15);
```

```csharp
Debug.Assert(SumOfProduct(4) == 56);
```

```csharp
Debug.Assert(SumOfProduct(1) == 1);
```
