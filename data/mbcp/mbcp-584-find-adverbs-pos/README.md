# mbcp584 -- Extract adverbs and their positions from a sentence

## Text

Write a function to find all adverbs and their positions in a given sentence by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public string FindAdverbs(string text)
{
    MatchCollection matches = Regex.Matches(text, @"\w+ly");
    foreach (Match m in matches)
    {
        return string.Format("{0}-{1}: {2}", m.Index, m.Index + m.Length, m.Value);
    }
    return null;
}
```

## Test List

```csharp
Debug.Assert(FindAdverbs("Clearly, he has no excuse for such behavior.") == "0-7: Clearly");
```

```csharp
Debug.Assert(FindAdverbs("Please handle the situation carefuly") == "28-36: carefuly");
```

```csharp
Debug.Assert(FindAdverbs("Complete the task quickly") == "18-25: quickly");
```
