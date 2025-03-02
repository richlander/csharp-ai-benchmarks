# mbcp608 -- Find the nth Bell number using a Python function

## Text

Write a C# function to find nth bell number.

## Code

```csharp
public int BellNumber(int n) 
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
Debug.Assert(BellNumber(3) == 5);
```

```csharp
Debug.Assert(BellNumber(4) == 15);
```
