# mbcp314 -- Max sum of non-adjacent numbers in 2xN grid

## Text

Write a function to find out the maximum sum such that no two chosen numbers are adjacent for the given rectangular grid of dimension 2 x n.

## Code

```csharp
public static int MaxSumRectangularGrid(int[][] grid, int n) 
{
    int incl = Math.Max(grid[0][0], grid[1][0]);
    int excl = 0;
    for (int i = 1; i < n; i++)
    {
        int exclNew = Math.Max(excl, incl);
        incl = excl + Math.Max(grid[0][i], grid[1][i]);
        excl = exclNew;
    }
    return Math.Max(excl, incl);
}
```

## Test List

```csharp
Debug.Assert(MaxSumRectangularGrid(new int[,] { { 1, 4, 5 }, { 2, 0, 0 } }, 3) == 7);
```

```csharp
Debug.Assert(MaxSumRectangularGrid(new int[][] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10 } }, 5) == 24);
```

```csharp
Debug.Assert(MaxSumRectangularGrid(new int[,] { { 7, 9, 11, 15, 19 }, { 21, 25, 28, 31, 32 } }, 5) == 81);
```
