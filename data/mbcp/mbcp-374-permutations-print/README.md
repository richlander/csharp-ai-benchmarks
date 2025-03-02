# mbcp374 -- Print all string permutations with duplicates included

## Text

Write a function to print all permutations of a given string including duplicates.

## Code

```csharp
public List<string> PermuteString(string str)
{
    if (str.Length == 0)
    {
        return new List<string> { "" };
    }
    var prevList = PermuteString(str.Substring(1));
    var nextList = new List<string>();
    foreach (var prev in prevList)
    {
        for (int j = 0; j <= str.Length; j++)
        {
            var newStr = prev.Substring(0, j) + str[0] + prev.Substring(j);
            if (!nextList.Contains(newStr))
            {
                nextList.Add(newStr);
            }
        }
    }
    return nextList;
}
```

## Test List

```csharp
Debug.Assert(PermuteString("ab").SequenceEqual(new List<string> { "ab", "ba" }));
```

```csharp
Debug.Assert(PermuteString("abc").SequenceEqual(new List<string> { "abc", "bac", "bca", "acb", "cab", "cba" }));
```

```csharp
Debug.Assert(PermuteString("abcd").SequenceEqual(new List<string> { "abcd", "bacd", "bcad", "bcda", "acbd", "cabd", "cbad", "cbda", "acdb", "cadb", "cdab", "cdba", "abdc", "badc", "bdac", "bdca", "adbc", "dabc", "dbac", "dbca", "adcb", "dacb", "dcab", "dcba" }));
```
