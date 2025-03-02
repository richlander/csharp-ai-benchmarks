# mbcp926 -- Find the n-th rencontres number efficiently

## Text

Write a function to find n-th rencontres number.

## Code

```csharp
int BinomialCoeff(int n, int k) 
{
    if (k == 0 || k == n) 
    {
        return 1;
    }
    return BinomialCoeff(n - 1, k - 1) + BinomialCoeff(n - 1, k);
}

int RencontresNumber(int n, int m) 
{
    if (n == 0 && m == 0) 
    {
        return 1;
    }
    if (n == 1 && m == 0) 
    {
        return 0;
    }
    if (m == 0) 
    {
        return (n - 1) * (RencontresNumber(n - 1, 0) + RencontresNumber(n - 2, 0));
    }
    return BinomialCoeff(n, m) * RencontresNumber(n - m, 0);
}
```

## Test List

```csharp
Debug.Assert(RencontresNumber(7, 2) == 924);
```

```csharp
Debug.Assert(RencontresNumber(3, 0) == 2);
```

```csharp
Debug.Assert(RencontresNumber(3, 1) == 3);
```
