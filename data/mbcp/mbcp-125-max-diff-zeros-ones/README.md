# mbcp125 -- Max difference of 0s and 1s in binary substring

## Text

Write a function to find the maximum difference between the number of 0s and number of 1s in any sub-string of the given binary string.

## Code

```csharp
public int FindLength(string str, int n) 
{ 
    int currentSum = 0; 
    int maxSum = 0; 
    for (int i = 0; i < n; i++) 
    { 
        currentSum += (str[i] == '0' ? 1 : -1); 
        if (currentSum < 0) 
        { 
            currentSum = 0; 
        } 
        maxSum = Math.Max(currentSum, maxSum); 
    } 
    return maxSum > 0 ? maxSum : 0; 
}
```

## Test List

```csharp
Debug.Assert(FindLength("11000010001", 11) == 6);
```

```csharp
Debug.Assert(FindLength("10111", 5) == 1);
```

```csharp
Debug.Assert(FindLength("11011101100101", 14) == 2);
```
