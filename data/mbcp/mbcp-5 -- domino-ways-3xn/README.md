# mbcp-5 -- Count domino arrangements for a 3 x n board

## Text

Write a function to find the number of ways to fill it with 2 x 1 dominoes for the given 3 x n board.

## Code

```csharp
public int CountWays(int n) 
{ 
    int[] A = new int[n + 1]; 
    int[] B = new int[n + 1]; 
    A[0] = 1; 
    A[1] = 0; 
    B[0] = 0; 
    B[1] = 1; 
    for (int i = 2; i <= n; i++) 
    { 
        A[i] = A[i - 2] + 2 * B[i - 1]; 
        B[i] = A[i - 1] + B[i - 2]; 
    } 
    return A[n]; 
}
```

## Test List

```csharp
Debug.Assert(CountWays(2) == 3);
```

```csharp
Debug.Assert(CountWays(8) == 153);
```

```csharp
Debug.Assert(CountWays(12) == 2131);
```
