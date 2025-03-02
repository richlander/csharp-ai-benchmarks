# mbcp938 -- Find three closest elements from three arrays

## Text

Write a function to find three closest elements from three sorted arrays.

## Code

```csharp
public static (int, int, int) FindCloset(int[] A, int[] B, int[] C, int p, int q, int r) 
{
    int diff = int.MaxValue;
    int res_i = 0;
    int res_j = 0;
    int res_k = 0;
    int i = 0;
    int j = 0;
    int k = 0;

    while (i < p && j < q && k < r) 
    {
        int minimum = Math.Min(A[i], Math.Min(B[j], C[k]));
        int maximum = Math.Max(A[i], Math.Max(B[j], C[k]));

        if (maximum - minimum < diff) 
        {
            res_i = i;
            res_j = j;
            res_k = k;
            diff = maximum - minimum;
        }

        if (diff == 0) 
        {
            break;
        }

        if (A[i] == minimum) 
        {
            i++;
        } 
        else if (B[j] == minimum) 
        {
            j++;
        } 
        else 
        {
            k++;
        }
    }

    return (A[res_i], B[res_j], C[res_k]);
}
```

## Test List

```csharp
Debug.Assert(FindCloset(new int[] { 1, 4, 10 }, new int[] { 2, 15, 20 }, new int[] { 10, 12 }, 3, 3, 2).Equals((10, 15, 10)));
```

```csharp
Debug.Assert(FindCloset(new[] { 20, 24, 100 }, new[] { 2, 19, 22, 79, 800 }, new[] { 10, 12, 23, 24, 119 }, 3, 5, 5).Equals((24, 22, 23)));
```

```csharp
Debug.Assert(FindCloset(new int[] { 2, 5, 11 }, new int[] { 3, 16, 21 }, new int[] { 11, 13 }, 3, 3, 2).Equals((11, 16, 11)));
```
