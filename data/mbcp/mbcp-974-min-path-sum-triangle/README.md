# mbcp974 -- Find minimum path sum in a triangle structure

## Text

Write a function to find the minimum total path sum in the given triangle.

## Code

```csharp
public int MinSumPath(int[][] A) 
{
    int[] memo = new int[A.Length];
    int n = A.Length - 1;
    for (int i = 0; i < A[n].Length; i++) 
    {
        memo[i] = A[n][i];
    }
    for (int i = A.Length - 2; i >= 0; i--) 
    {
        for (int j = 0; j < A[i].Length; j++) 
        {
            memo[j] = A[i][j] + Math.Min(memo[j], memo[j + 1]);
        }
    }
    return memo[0];
}
```

## Test List

```csharp
Debug.Assert(MinSumPath(new int[][] { new int[] { 2 }, new int[] { 3, 9 }, new int[] { 1, 6, 7 } }) == 6);
```

```csharp
Debug.Assert(MinSumPath(new int[][] { new int[] { 2 }, new int[] { 3, 7 }, new int[] { 8, 5, 6 } }) == 10);
```

```csharp
Debug.Assert(MinSumPath(new int[][] { new int[] { 3 }, new int[] { 6, 4 }, new int[] { 5, 2, 7 } }) == 9);
```
