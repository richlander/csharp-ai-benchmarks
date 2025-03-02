# mbcp-772 -- Remove all words of k length from a string

## Text

Write a function to remove all the words with k length in the given string.

## Code

```csharp
public string RemoveLength(string testStr, int K)
{
    string[] temp = testStr.Split(' ');
    List<string> res = new List<string>();
    foreach (string ele in temp)
    {
        if (ele.Length != K)
        {
            res.Add(ele);
        }
    }
    return string.Join(" ", res);
}
```

## Test List

```csharp
Debug.Assert(RemoveLength("The person is most value tet", 3) == "person is most value");
```

```csharp
Debug.Assert(RemoveLength("If you told me about this ok", 4) == "If you me about ok");
```

```csharp
Debug.Assert(RemoveLength("Forces of darkeness is come into the play", 4) == "Forces of darkeness is the");
```
