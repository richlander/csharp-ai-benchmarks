# mbcp601 -- Find the longest chain from pairs of elements

## Text

Write a function to find the longest chain which can be formed from the given set of pairs.

## Code

```csharp
class Pair
{
    public int A { get; set; }
    public int B { get; set; }

    public Pair(int a, int b)
    {
        A = a;
        B = b;
    }
}

public int MaxChainLength(Pair[] arr, int n)
{
    int max = 0;
    int[] mcl = new int[n];
    for (int i = 0; i < n; i++)
    {
        mcl[i] = 1;
    }
    for (int i = 1; i < n; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (arr[i].A > arr[j].B && mcl[i] < mcl[j] + 1)
            {
                mcl[i] = mcl[j] + 1;
            }
        }
    }
    for (int i = 0; i < n; i++)
    {
        if (max < mcl[i])
        {
            max = mcl[i];
        }
    }
    return max;
}
```

## Test List

```csharp
Debug.Assert(MaxChainLength(new Pair[] { new Pair(5, 24), new Pair(15, 25), new Pair(27, 40), new Pair(50, 60) }, 4) == 3);
```

```csharp
Debug.Assert(MaxChainLength(new Pair[] { new Pair(1, 2), new Pair(3, 4), new Pair(5, 6), new Pair(7, 8) }) == 4);
```

```csharp
Debug.Assert(MaxChainLength(new List<Pair> { new Pair(19, 10), new Pair(11, 12), new Pair(13, 14), new Pair(15, 16), new Pair(31, 54) }) == 5);
```
