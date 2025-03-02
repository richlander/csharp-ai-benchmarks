# mbcp-423 -- Function to find max gold in mine path

## Text

Write a function to solve gold mine problem.

## Code

```csharp
public int GetMaxGold(int[][] gold, int m, int n) 
{
    int[][] goldTable = new int[m][];
    for (int j = 0; j < m; j++)
    {
        goldTable[j] = new int[n];
    }

    for (int col = n - 1; col >= 0; col--)
    {
        for (int row = 0; row < m; row++)
        {
            int right = (col == n - 1) ? 0 : goldTable[row][col + 1];
            int right_up = (row == 0 || col == n - 1) ? 0 : goldTable[row - 1][col + 1];
            int right_down = (row == m - 1 || col == n - 1) ? 0 : goldTable[row + 1][col + 1];
            goldTable[row][col] = gold[row][col] + Math.Max(right, Math.Max(right_up, right_down));
        }
    }

    int res = goldTable[0][0];
    for (int i = 1; i < m; i++)
    {
        res = Math.Max(res, goldTable[i][0]);
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(GetMaxGold(new int[][] { new int[] { 1, 3, 1, 5 }, new int[] { 2, 2, 4, 1 }, new int[] { 5, 0, 2, 3 }, new int[] { 0, 6, 1, 2 } }, 4, 4) == 16);
```

```csharp
Debug.Assert(GetMaxGold(new int[,] {{10,20},{30,40}}, 2, 2) == 70);
```

```csharp
Debug.Assert(GetMaxGold(new int[,] {{4,9},{3,7}}, 2, 2) == 13);
```
