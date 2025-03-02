# mbcp867 -- Add a number to make array sum even

## Text

Write a C# function to add a minimum number such that the sum of array becomes even.

## Code

```csharp
public int MinNum(int[] arr, int n)  
{  
    int odd = 0;  
    for (int i = 0; i < n; i++)  
    {  
        if (arr[i] % 2 != 0)  
        {  
            odd++;  
        }  
    }  
    if (odd % 2 != 0)  
    {  
        return 1;  
    }  
    return 2;  
}
```

## Test List

```csharp
Debug.Assert(MinNum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9) == 1);
```

```csharp
Debug.Assert(MinNum(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8) == 2);
```

```csharp
Debug.Assert(MinNum(new int[] { 1, 2, 3 }, 3) == 2);
```
