# mbcp-863 -- Find the longest subsequence of consecutive integers

## Text

Write a function to find the length of the longest sub-sequence such that elements in the subsequences are consecutive integers.

## Code

```csharp
public int FindLongestConseqSubseq(int[] arr, int n) 
{
    int ans = 0;
    int count = 0;
    Array.Sort(arr);
    List<int> v = new List<int>();
    v.Add(arr[0]);
    for (int i = 1; i < n; i++)
    {
        if (arr[i] != arr[i - 1])
        {
            v.Add(arr[i]);
        }
    }
    for (int i = 0; i < v.Count; i++)
    {
        if (i > 0 && v[i] == v[i - 1] + 1)
        {
            count++;
        }
        else
        {
            count = 1;
        }
        ans = Math.Max(ans, count);
    }
    return ans;
}
```

## Test List

```csharp
Debug.Assert(FindLongestConseqSubseq(new int[] { 1, 2, 2, 3 }, 4) == 3);
```

```csharp
Debug.Assert(FindLongestConseqSubseq(new int[] { 1, 9, 3, 10, 4, 20, 2 }, 7) == 4);
```

```csharp
Debug.Assert(FindLongestConseqSubseq(new int[] { 36, 41, 56, 35, 44, 33, 34, 92, 43, 32, 42 }, 11) == 5);
```
