# mbcp60 -- Find max subsequence length with adjacent difference

## Text

Write a function to find the maximum length of the subsequence with difference between adjacent elements for the given array.

## Code

```csharp
int MaxLenSub(int[] arr, int n) 
{ 
    List<int> mls = new List<int>(); 
    int max = 0; 
    for (int i = 0; i < n; i++) 
    { 
        mls.Add(1); 
    } 
    for (int i = 0; i < n; i++) 
    { 
        for (int j = 0; j < i; j++) 
        { 
            if (Math.Abs(arr[i] - arr[j]) <= 1 && mls[i] < mls[j] + 1) 
            { 
                mls[i] = mls[j] + 1; 
            } 
        } 
    } 
    for (int i = 0; i < n; i++) 
    { 
        if (max < mls[i]) 
        { 
            max = mls[i]; 
        } 
    } 
    return max; 
}
```

## Test List

```csharp
Debug.Assert(MaxLenSub(new int[] { 2, 5, 6, 3, 7, 6, 5, 8 }, 8) == 5);
```

```csharp
Debug.Assert(MaxLenSub(new int[] { -2, -1, 5, -1, 4, 0, 3 }, 7) == 4);
```

```csharp
Debug.Assert(MaxLenSub(new int[] { 9, 11, 13, 15, 18 }, 5) == 1);
```
