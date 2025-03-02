# mbcp633 -- Sum of XOR for all pairs in an array

## Text

Write a C# function to find the sum of xor of all pairs of numbers in the given array.

## Code

```csharp
public int PairOrSum(int[] arr, int n) 
{
    int ans = 0; 
    for (int i = 0; i < n; i++) 
    {    
        for (int j = i + 1; j < n; j++) 
        {   
            ans += (arr[i] ^ arr[j]);          
        }
    }
    return ans; 
}
```

## Test List

```csharp
Debug.Assert(PairOrSum(new int[] { 5, 9, 7, 6 }, 4) == 47);
```

```csharp
Debug.Assert(PairOrSum(new int[] { 7, 3, 5 }, 3) == 12);
```

```csharp
Debug.Assert(PairOrSum(new int[] { 7, 3 }, 2) == 4);
```
