# mbcp-952 -- Compute nCr modulo p using a function

## Text

Write a function to compute the value of ncr mod p.

## Code

```csharp
public static int NCrModP(int n, int r, int p) 
{
    if (r > n - r) 
    {
        r = n - r;
    }

    int[] C = new int[r + 1];
    C[0] = 1;

    for (int i = 1; i <= n; i++) 
    {
        for (int j = Math.Min(i, r); j > 0; j--) 
        {
            C[j] = (C[j] + C[j - 1]) % p;
        }
    }
    
    return C[r];
}
```

## Test List

```csharp
Debug.Assert(NCrModP(10, 2, 13) == 6);
```

```csharp
Debug.Assert(NCrModP(11, 3, 14) == 11);
```

```csharp
Debug.Assert(NCrModP(18, 14, 19) == 1);
```
