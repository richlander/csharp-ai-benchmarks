# mbcp147 -- Find the max path sum in a triangle array

## Text

Write a function to find the maximum total path sum in the given triangle.

## Code

```csharp
public int MaxPathSum(int[][] tri, int m, int n) 
{
    for (int i = m - 1; i >= 0; i--) 
    {
        for (int j = 0; j <= i; j++) 
        {
            if (tri[i + 1][j] > tri[i + 1][j + 1]) 
            {
                tri[i][j] += tri[i + 1][j];
            } 
            else 
            {
                tri[i][j] += tri[i + 1][j + 1];
            }
        }
    }
    return tri[0][0];
}
```

## Test List

```csharp
Debug.Assert(MaxPathSum(new int[][] { new int[] { 1, 0, 0 }, new int[] { 4, 8, 0 }, new int[] { 1, 5, 3 } }, 2, 2) == 14);
```

```csharp
Debug.Assert(MaxPathSum(new int[][] { new int[] { 13, 0, 0 }, new int[] { 7, 4, 0 }, new int[] { 2, 4, 6 } }, 2, 2) == 24);
```

```csharp
Debug.Assert(MaxPathSum(new int[,] { { 2, 0, 0 }, { 11, 18, 0 }, { 21, 25, 33 } }, 2, 2) == 53);
```
