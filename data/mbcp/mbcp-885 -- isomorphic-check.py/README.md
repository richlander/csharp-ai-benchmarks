# mbcp-885 -- Check if two strings are isomorphic in Python

## Text

Write a C# function to check whether the two given strings are isomorphic to each other or not.

## Code

```csharp
public bool IsIsomorphic(string str1, string str2)         
{
    var dictStr1 = new Dictionary<char, List<int>>();
    var dictStr2 = new Dictionary<char, List<int>>();
    
    for (int i = 0; i < str1.Length; i++)
    {
        if (!dictStr1.ContainsKey(str1[i]))
        {
            dictStr1[str1[i]] = new List<int>();
        }
        dictStr1[str1[i]].Add(i);
    }
    
    for (int j = 0; j < str2.Length; j++)
    {
        if (!dictStr2.ContainsKey(str2[j]))
        {
            dictStr2[str2[j]] = new List<int>();
        }
        dictStr2[str2[j]].Add(j);
    }
    
    return dictStr1.Values.OrderBy(x => x.Count).ToList().SequenceEqual(dictStr2.Values.OrderBy(x => x.Count).ToList());
}
```

## Test List

```csharp
Debug.Assert(IsIsomorphic("paper", "title") == true);
```

```csharp
Debug.Assert(IsIsomorphic("ab", "ba") == true);
```

```csharp
Debug.Assert(IsIsomorphic("ab", "aa") == false);
```
