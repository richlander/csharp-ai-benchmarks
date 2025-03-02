# mbcp-576 -- Check if one array is a subarray of another

## Text

Write a C# function to check whether an array is subarray of another or not.

## Code

```csharp
public static bool IsSubArray(int[] A, int[] B, int n, int m) 
{
    int i = 0, j = 0; 
    while (i < n && j < m) 
    {  
        if (A[i] == B[j]) 
        {
            i++; 
            j++; 
            if (j == m) 
                return true;  
        } 
        else 
        {
            i = i - j + 1; 
            j = 0;       
        } 
    }
    return false;  
}
```

## Test List

```csharp
Debug.Assert(IsSubArray(new int[] { 1, 4, 3, 5 }, new int[] { 1, 2 }, 4, 2) == false);
```

```csharp
Debug.Assert(IsSubArray(new int[] { 1, 2, 1 }, new int[] { 1, 2, 1 }, 3, 3) == true);
```

```csharp
Debug.Assert(IsSubArray(new int[] { 1, 0, 2, 2 }, new int[] { 2, 2, 0 }, 4, 3) == false);
```
