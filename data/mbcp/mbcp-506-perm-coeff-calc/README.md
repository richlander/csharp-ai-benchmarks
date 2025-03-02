# mbcp506 -- Calculate permutation coefficient p(n, k) function

## Text

Write a function to calculate the permutation coefficient of given p(n, k).

## Code

```csharp
public int PermutationCoefficient(int n, int k) 
{
    int[][] P = new int[n + 1][];
    for (int j = 0; j <= n; j++)
    {
        P[j] = new int[k + 1];
    }

    for (int i = 0; i <= n; i++) 
    {
        for (int j = 0; j <= Math.Min(i, k); j++) 
        {
            if (j == 0) 
            {
                P[i][j] = 1;
            } 
            else 
            {
                P[i][j] = P[i - 1][j] + (j * P[i - 1][j - 1]);
            }
            if (j < k) 
            {
                P[i][j + 1] = 0;
            }
        }
    }
    return P[n][k];
}
```

## Test List

```csharp
Debug.Assert(PermutationCoefficient(10, 2) == 90);
```

```csharp
Debug.Assert(PermutationCoefficient(10, 3) == 720);
```

```csharp
Debug.Assert(PermutationCoefficient(10, 1) == 10);
```
