# mbcp384 -- Find frequency of smallest value in an array

## Text

Write a C# function to find the frequency of the smallest value in a given array.

## Code

```csharp
public int FrequencyOfSmallest(int n, int[] arr) 
{ 
    int mn = arr[0]; 
    int freq = 1; 
    for (int i = 1; i < n; i++) 
    { 
        if (arr[i] < mn) 
        { 
            mn = arr[i]; 
            freq = 1; 
        } 
        else if (arr[i] == mn) 
        { 
            freq++; 
        } 
    } 
    return freq; 
}
```

## Test List

```csharp
Debug.Assert(FrequencyOfSmallest(5, new int[] { 1, 2, 3, 4, 3 }) == 1);
```

```csharp
Debug.Assert(FrequencyOfSmallest(7, new int[] { 3, 1, 2, 5, 6, 2, 3 }) == 1);
```

```csharp
Debug.Assert(FrequencyOfSmallest(7, new int[] { 3, 3, 6, 3, 7, 4, 9 }) == 3);
```
