# mbcp767 -- Count pairs with specified sum in a list

## Text

Write a C# function to count the number of pairs whose sum is equal to ‘sum’.

## Code

```csharp
public int GetPairsCount(int[] arr, int n, int sum)  
{  
    int count = 0;  
    for (int i = 0; i < n; i++)  
    {  
        for (int j = i + 1; j < n; j++)  
        {  
            if (arr[i] + arr[j] == sum)  
            {  
                count++;  
            }  
        }  
    }  
    return count;  
}
```

## Test List

```csharp
Debug.Assert(GetPairsCount(new int[] { 1, 1, 1, 1 }, 4, 2) == 6);
```

```csharp
Debug.Assert(GetPairsCount(new int[] { 1, 5, 7, -1, 5 }, 5, 6) == 3);
```

```csharp
Debug.Assert(GetPairsCount(new int[] { 1, -2, 3 }, 3, 1) == 1);
```
