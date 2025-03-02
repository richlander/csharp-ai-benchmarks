# mbcp67 -- Count the partitions of a set of bell numbers

## Text

Write a function to find the number of ways to partition a set of bell numbers.

## Code

```csharp
public static int BellNumber(int n)   
{   
    int[,] bell = new int[n + 1, n + 1];   
    bell[0, 0] = 1;   
    for (int i = 1; i <= n; i++)   
    {   
        bell[i, 0] = bell[i - 1, i - 1];   
        for (int j = 1; j <= i; j++)   
        {   
            bell[i, j] = bell[i - 1, j - 1] + bell[i, j - 1];   
        }   
    }   
    return bell[n, 0];   
}
```

## Test List

```csharp
Debug.Assert(BellNumber(2) == 2);
```

```csharp
Debug.Assert(BellNumber(10) == 115975);
```

```csharp
Debug.Assert(BellNumber(56) == 6775685320645824322581483068371419745979053216268760300);
```
