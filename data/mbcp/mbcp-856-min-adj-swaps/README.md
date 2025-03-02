# mbcp856 -- Find minimum swaps to sort binary array

## Text

Write a C# function to find minimum adjacent swaps required to sort binary array.

## Code

```csharp
int FindMinSwaps(int[] arr, int n) 
{
    int[] noOfZeroes = new int[n];
    int count = 0;
    noOfZeroes[n - 1] = 1 - arr[n - 1];
    
    for (int i = n - 2; i >= 0; i--) 
    {
        noOfZeroes[i] = noOfZeroes[i + 1];
        if (arr[i] == 0) 
        {
            noOfZeroes[i] += 1;
        }
    }
    
    for (int i = 0; i < n; i++) 
    {
        if (arr[i] == 1) 
        {
            count += noOfZeroes[i];
        }
    }
    
    return count;
}
```

## Test List

```csharp
Debug.Assert(FindMinSwaps(new int[] { 1, 0, 1, 0 }, 4) == 3);
```

```csharp
Debug.Assert(FindMinSwaps(new int[] { 0, 1, 0 }, 3) == 1);
```

```csharp
Debug.Assert(FindMinSwaps(new int[] { 0, 0, 1, 1, 0 }, 5) == 2);
```
