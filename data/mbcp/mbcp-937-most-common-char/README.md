# mbcp937 -- Count the most frequent character in a string

## Text

Write a function to count the most common character in a given string.

## Code

```csharp
using System.Collections.Generic;
using System.Linq;

public class CharacterCounter
{
    public char MaxChar(string str1)
    {
        var temp = str1.GroupBy(c => c)
                       .ToDictionary(g => g.Key, g => g.Count());
        return temp.OrderByDescending(pair => pair.Value)
                   .First().Key;
    }
}
```

## Test List

```csharp
Debug.Assert(MaxChar("hello world") == 'l');

char MaxChar(string input) {
    return input.GroupBy(c => c)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
}
```

```csharp
Debug.Assert(MaxChar("hello ") == 'l');

char MaxChar(string input)
{
    // Implementation to find the maximum character
}
```

```csharp
Debug.Assert(MaxChar("python pr") == 'p');
```
