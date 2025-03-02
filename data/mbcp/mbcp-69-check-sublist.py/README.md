# mbcp69 -- Check if list contains specified sublist

## Text

Write a function to check whether a list contains the given sublist or not.

## Code

```csharp
public bool IsSublist(List<int> l, List<int> s) 
{
    bool subSet = false;
    if (s.Count == 0) 
    {
        subSet = true;
    } 
    else if (s.SequenceEqual(l)) 
    {
        subSet = true;
    } 
    else if (s.Count > l.Count) 
    {
        subSet = false;
    } 
    else 
    {
        for (int i = 0; i < l.Count; i++) 
        {
            if (l[i] == s[0]) 
            {
                int n = 1;
                while (n < s.Count && l[i + n] == s[n]) 
                {
                    n++;
                }
                if (n == s.Count) 
                {
                    subSet = true;
                }
            }
        }
    }
    return subSet;
}
```

## Test List

```csharp
Debug.Assert(IsSublist(new List<int> { 2, 4, 3, 5, 7 }, new List<int> { 3, 7 }) == false);
```

```csharp
Debug.Assert(IsSublist(new List<int> { 2, 4, 3, 5, 7 }, new List<int> { 4, 3 }) == true);
```

```csharp
Debug.Assert(IsSublist(new List<int> { 2, 4, 3, 5, 7 }, new List<int> { 1, 6 }) == false);
```
