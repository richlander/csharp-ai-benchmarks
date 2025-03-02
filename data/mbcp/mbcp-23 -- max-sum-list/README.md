# mbcp-23 -- Find max sum of list elements in a list of lists

## Text

Write a C# function to find the maximum sum of elements of list in a list of lists.

## Code

```csharp
public static int MaximumSum(List<List<int>> list1) 
{
    int maxi = -100000;
    foreach (var x in list1) 
    {
        int sum = 0;
        foreach (var y in x) 
        {
            sum += y;      
        }
        maxi = Math.Max(sum, maxi);
    }
    return maxi;
}
```

## Test List

```csharp
Debug.Assert(MaximumSum(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 10, 11, 12 }, new int[] { 7, 8, 9 } }) == 33);
```

```csharp
Debug.Assert(MaximumSum(new int[,] { { 0, 1, 1 }, { 1, 1, 2 }, { 3, 2, 1 } }) == 6);
```

```csharp
Debug.Assert(MaximumSum(new int[][] { new int[] { 0, 1, 3 }, new int[] { 1, 2, 1 }, new int[] { 9, 8, 2 }, new int[] { 0, 1, 0 }, new int[] { 6, 4, 8 } }) == 19);
```
