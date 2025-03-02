# mbcp-757 -- Count reverse string pairs in a list

## Text

Write a function to count the pairs of reverse strings in the given string list.

## Code

```csharp
public static string CountReversePairs(List<string> testList)
{
    int res = testList.SelectMany((value, idx) => 
        Enumerable.Range(idx, testList.Count - idx)
            .Count(idxn => testList[idxn] == string.Concat(testList[idx].Reverse())))
        .Sum();
    return res.ToString();
}
```

## Test List

```csharp
Debug.Assert(CountReversePairs(new string[] { "julia", "best", "tseb", "for", "ailuj" }) == 2);
```

```csharp
Debug.Assert(CountReversePairs(new string[] { "geeks", "best", "for", "skeeg" }) == '1');
```

```csharp
Debug.Assert(CountReversePairs(new string[] { "makes", "best", "sekam", "for", "rof" }) == "2");
```
