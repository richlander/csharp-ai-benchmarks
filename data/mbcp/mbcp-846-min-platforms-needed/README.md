# mbcp846 -- Calculate platforms needed for a railway or bus station

## Text

Write a function to find the minimum number of platforms required for a railway/bus station.

## Code

```csharp
public static int FindPlatform(int[] arr, int[] dep, int n) 
{
    Array.Sort(arr);
    Array.Sort(dep);
    int platNeeded = 1;
    int result = 1;
    int i = 1;
    int j = 0;
    while (i < n && j < n) 
    {
        if (arr[i] <= dep[j]) 
        {
            platNeeded++;
            i++;
        }
        else if (arr[i] > dep[j]) 
        {
            platNeeded--;
            j++;
        }
        if (platNeeded > result) 
        {
            result = platNeeded;
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(FindPlatform(new int[] { 900, 940, 950, 1100, 1500, 1800 }, new int[] { 910, 1200, 1120, 1130, 1900, 2000 }, 6) == 3);
```

```csharp
Debug.Assert(FindPlatform(new int[] { 100, 200, 300, 400 }, new int[] { 700, 800, 900, 1000 }, 4) == 4);
```

```csharp
Debug.Assert(FindPlatform(new int[] { 5, 6, 7, 8 }, new int[] { 4, 3, 2, 1 }, 4) == 1);
```
