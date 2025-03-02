# mbcp515 -- Check for subset sum divisible by m

## Text

Write a function to check if there is a subset with sum divisible by m.

## Code

```csharp
bool ModularSum(int[] arr, int n, int m) 
{ 
    if (n > m) 
    { 
        return true; 
    } 
    bool[] DP = new bool[m]; 
    for (int i = 0; i < n; i++) 
    { 
        if (DP[0]) 
        { 
            return true; 
        } 
        bool[] temp = new bool[m]; 
        for (int j = 0; j < m; j++) 
        { 
            if (DP[j]) 
            { 
                if (!DP[(j + arr[i]) % m]) 
                { 
                    temp[(j + arr[i]) % m] = true; 
                } 
            } 
        } 
        for (int j = 0; j < m; j++) 
        { 
            if (temp[j]) 
            { 
                DP[j] = true; 
            } 
        } 
        DP[arr[i] % m] = true; 
    } 
    return DP[0]; 
}
```

## Test List

```csharp
Debug.Assert(ModularSum(new int[] { 3, 1, 7, 5 }, 4, 6) == true);
```

```csharp
Debug.Assert(ModularSum(new int[] { 1, 7 }, 2, 5) == false);
```

```csharp
Debug.Assert(ModularSum(new int[] { 1, 6 }, 2, 5) == false);
```
