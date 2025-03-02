# mbcp-231 -- Maximize the sum in a right triangle of numbers

## Text

Write a function to find the maximum sum in the given right triangle of numbers.

## Code

```csharp
public static int MaxSum(int[][] tri, int n) 
{
    if (n > 1) 
    {
        tri[1][1] += tri[0][0];
        tri[1][0] += tri[0][0];
    }
    for (int i = 2; i < n; i++) 
    {
        tri[i][0] += tri[i - 1][0];
        tri[i][i] += tri[i - 1][i - 1];
        for (int j = 1; j < i; j++) 
        {
            if (tri[i][j] + tri[i - 1][j - 1] >= tri[i][j] + tri[i - 1][j]) 
            {
                tri[i][j] += tri[i - 1][j - 1];
            } 
            else 
            {
                tri[i][j] += tri[i - 1][j];
            }
        }
    }
    return tri[n - 1].Max();
}
```

## Test List

```csharp
Debug.Assert(MaxSum(new int[][] { new int[] { 1 }, new int[] { 2, 1 }, new int[] { 3, 3, 2 } }, 3) == 6);
```

```csharp
Debug.Assert(MaxSum(new int[][] { new int[] { 1 }, new int[] { 1, 2 }, new int[] { 4, 1, 12 } }, 3) == 15);
```

```csharp
Debug.Assert(MaxSum(new int[][] { new int[] { 2 }, new int[] { 3, 2 }, new int[] { 13, 23, 12 } }, 3) == 28);
```
