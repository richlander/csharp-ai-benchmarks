# mbcp-489 -- Find frequency of largest value in an array

## Text

Write a C# function to find the frequency of the largest value in a given array.

## Code

```csharp
public int FrequencyOfLargest(int n, int[] arr) 
{ 
    int mn = arr[0]; 
    int freq = 1; 
    for (int i = 1; i < n; i++) 
    { 
        if (arr[i] > mn) 
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
Debug.Assert(FrequencyOfLargest(5, new int[] { 1, 2, 3, 4, 4 }) == 2);
```

```csharp
Debug.Assert(FrequencyOfLargest(3, new int[] { 5, 6, 5 }) == 1);
```

```csharp
Debug.Assert(FrequencyOfLargest(4, new int[] { 2, 7, 7, 7 }) == 3);
```
