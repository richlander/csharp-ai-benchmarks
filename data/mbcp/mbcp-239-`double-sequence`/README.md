# mbcp239 -- Count valid sequences with specific growth constraints

## Text

Write a function to find the number of possible sequences of length n such that each of the next element is greater than or equal to twice of the previous element but less than or equal to m.

## Code

```csharp
public int GetTotalNumberOfSequences(int m, int n) 
{
    int[,] T = new int[m + 1, n + 1];
    for (int i = 0; i <= m; i++) 
    {
        for (int j = 0; j <= n; j++) 
        {
            if (i == 0 || j == 0) 
            {
                T[i, j] = 0;
            } 
            else if (i < j) 
            {
                T[i, j] = 0;
            } 
            else if (j == 1) 
            {
                T[i, j] = i;
            } 
            else 
            {
                T[i, j] = T[i - 1, j] + T[i / 2, j - 1];
            }
        }
    }
    return T[m, n];
}
```

## Test List

```csharp
Debug.Assert(GetTotalNumberOfSequences(10, 4) == 4);
```

```csharp
Debug.Assert(GetTotalNumberOfSequences(5, 2) == 6);
```

```csharp
Debug.Assert(GetTotalNumberOfSequences(16, 3) == 84);
```
