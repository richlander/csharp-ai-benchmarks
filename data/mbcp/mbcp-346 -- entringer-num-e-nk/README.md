# mbcp-346 -- Function to compute entringer number e(n, k)

## Text

Write a function to find entringer number e(n, k).

## Code

```csharp
public int Zigzag(int n, int k) 
{ 
    if (n == 0 && k == 0) 
        return 1; 
    if (k == 0) 
        return 0; 
    return Zigzag(n, k - 1) + Zigzag(n - 1, n - k); 
}
```

## Test List

```csharp
Debug.Assert(Zigzag(4, 3) == 5);
```

```csharp
Debug.Assert(Zigzag(4, 2) == 4);
```

```csharp
Debug.Assert(Zigzag(3, 1) == 1);
```
