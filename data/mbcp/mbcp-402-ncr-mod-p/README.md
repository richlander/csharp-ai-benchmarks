# mbcp402 -- Compute n choose r modulo p

## Text

Write a function to compute the value of ncr%p.

## Code

```csharp
public static int NcrModp(int n, int r, int p) 
{ 
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
Debug.Assert(NcrModp(10, 2, 13) == 6);
```

```csharp
Debug.Assert(NcrModp(15, 12, 43) == 25);
```

```csharp
Debug.Assert(NcrModp(17, 9, 18) == 10);
```
