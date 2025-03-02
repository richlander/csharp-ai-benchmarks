# mbcp-953 -- Find minimum subsets with distinct elements in Python

## Text

Write a C# function to find the minimun number of subsets with distinct elements.

## Code

```csharp
public int Subset(int[] ar, int n) 
{
    int res = 0;
    Array.Sort(ar);
    for (int i = 0; i < n; i++) 
    {
        int count = 1;
        for (int j = i + 1; j < n; j++) 
        {
            if (ar[i] == ar[j]) 
            {
                count++;
            } 
            else 
            {
                break;
            }
        }
        res = Math.Max(res, count);
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(Subset(new List<int> { 1, 2, 3, 4 }, 4) == 1);
```

```csharp
Debug.Assert(Subset(new List<int> { 5, 6, 9, 3, 4, 3, 4 }, 7) == 2);
```

```csharp
Debug.Assert(Subset(new int[] { 1, 2, 3 }, 3) == 1);
```
