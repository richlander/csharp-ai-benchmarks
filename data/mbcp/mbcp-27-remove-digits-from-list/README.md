# mbcp27 -- Remove digits from a list of strings using Python

## Text

Write a C# function to remove all digits from a list of strings.

## Code

```csharp
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Example
{
    public List<string> Remove(List<string> list)
    {
        string pattern = "[0-9]";
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = Regex.Replace(list[i], pattern, "");
        }
        return list;
    }
}
```

## Test List

```csharp
Debug.Assert(Remove(new List<string> { "4words", "3letters", "4digits" }).SequenceEqual(new List<string> { "words", "letters", "digits" }));
```

```csharp
Debug.Assert(Remove(new List<string> { "28Jan", "12Jan", "11Jan" }).SequenceEqual(new List<string> { "Jan", "Jan", "Jan" }));
```

```csharp
Debug.Assert(Remove(new List<string> { "wonder1", "wonder2", "wonder3" }).SequenceEqual(new List<string> { "wonder", "wonder", "wonder" }));
```
