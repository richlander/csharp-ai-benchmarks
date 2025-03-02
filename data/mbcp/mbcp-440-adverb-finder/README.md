# mbcp440 -- Find adverbs and their positions in a sentence

## Text

Write a function to find all adverbs and their positions in a given sentence.

## Code

```csharp
using System.Text.RegularExpressions;

public static (int, int, string) FindAdverbPosition(string text)
{
    var match = Regex.Match(text, @"\w+ly");
    if (match.Success)
    {
        return (match.Index, match.Index + match.Length, match.Value);
    }
    return (-1, -1, null);
}
```

## Test List

```csharp
Debug.Assert(FindAdverbPosition("clearly!! we can see the sky").Equals((0, 7, 'clearly')));
```

```csharp
Debug.Assert(FindAdverbPosition("seriously!! there are many roses").Equals((0, 9, 'seriously')));
```

```csharp
Debug.Assert(FindAdverbPosition("unfortunately!! sita is going to home").Equals((0, 13, 'unfortunately')));
```
