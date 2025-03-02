# mbcp-245 -- Find max sum of bi-tonic subsequence in array

## Text

Write a function to find the maximum sum of bi-tonic sub-sequence for the given array.

## Code

```csharp
public static int MaxSum(int[] arr, int n) 
{
    int[] MSIBS = (int[])arr.Clone(); 
    for (int i = 0; i < n; i++) 
    {
        for (int j = 0; j < i; j++) 
        {
            if (arr[i] > arr[j] && MSIBS[i] < MSIBS[j] + arr[i]) 
            {
                MSIBS[i] = MSIBS[j] + arr[i]; 
            }
        }
    }
    
    int[] MSDBS = (int[])arr.Clone(); 
    for (int i = 1; i <= n; i++) 
    {
        for (int j = 1; j < i; j++) 
        {
            if (arr[arr.Length - i] > arr[arr.Length - j] && MSDBS[arr.Length - i] < MSDBS[arr.Length - j] + arr[arr.Length - i]) 
            {
                MSDBS[arr.Length - i] = MSDBS[arr.Length - j] + arr[arr.Length - i]; 
            }
        }
    }
    
    int maxSum = int.MinValue; 
    for (int i = 0; i < n; i++) 
    {
        maxSum = Math.Max(maxSum, MSIBS[i] + MSDBS[arr.Length - i - 1] - arr[i]); 
    }
    
    return maxSum; 
}
```

## Test List

```csharp
Debug.Assert(MaxSum(new int[] { 1, 15, 51, 45, 33, 100, 12, 18, 9 }, 9) == 194);
```

```csharp
Debug.Assert(MaxSum(new int[] { 80, 60, 30, 40, 20, 10 }, 6) == 210);
```

```csharp
Debug.Assert(MaxSum(new int[] { 2, 3, 14, 16, 21, 23, 29, 30 }, 8) == 138);
```
