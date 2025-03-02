# mbcp300 -- Count balanced binary sequences of length 2n

## Text

Write a function to find the count of all binary sequences of length 2n such that sum of first n bits is same as sum of last n bits.

## Code

```csharp
public double CountBinarySeq(int n) 
{ 
    double nCr = 1; 
    double res = 1; 
    for (int r = 1; r <= n; r++) 
    { 
        nCr = (nCr * (n + 1 - r)) / r; 
        res += nCr * nCr; 
    } 
    return res; 
}
```

## Test List

```csharp
Debug.Assert(CountBinarySeq(1) == 2.0);
```

```csharp
Debug.Assert(CountBinarySeq(2) == 6.0);
```

```csharp
Debug.Assert(CountBinarySeq(3) == 20.0);
```
