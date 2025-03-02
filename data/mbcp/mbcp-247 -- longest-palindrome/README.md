# mbcp-247 -- Find longest palindromic subsequence in string

## Text

Write a function to find the longest palindromic subsequence in the given string.

## Code

```csharp
public int Lps(string str) 
{
    int n = str.Length; 
    int[,] L = new int[n, n]; 
    for (int i = 0; i < n; i++) 
    {
        L[i, i] = 1;
    }
    for (int cl = 2; cl <= n; cl++) 
    {
        for (int i = 0; i <= n - cl; i++) 
        {
            int j = i + cl - 1;
            if (str[i] == str[j] && cl == 2) 
            {
                L[i, j] = 2;
            }
            else if (str[i] == str[j]) 
            {
                L[i, j] = L[i + 1, j - 1] + 2;
            }
            else 
            {
                L[i, j] = Math.Max(L[i, j - 1], L[i + 1, j]);
            }
        }
    }
    return L[0, n - 1];
}
```

## Test List

```csharp
Debug.Assert(Lps("TENS FOR TENS") == 5);
```

```csharp
Debug.Assert(Lps("CARDIO FOR CARDS") == 7);
```

```csharp
Debug.Assert(Lps("PART OF THE JOURNEY IS PART") == 9);
```
