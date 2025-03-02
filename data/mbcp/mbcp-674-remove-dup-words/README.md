# mbcp674 -- Remove duplicate words from a string with collections

## Text

Write a function to remove duplicate words from a given string using collections module.

## Code

```csharp
using System.Collections.Generic;

public class StringManipulator
{
    public string RemoveDuplicate(string input)
    {
        var seen = new HashSet<string>();
        var result = new List<string>();

        foreach (var word in input.Split(' '))
        {
            if (seen.Add(word))
            {
                result.Add(word);
            }
        }

        return string.Join(" ", result);
    }
}
```

## Test List

```csharp
Debug.Assert(RemoveDuplicate("Python Exercises Practice Solution Exercises") == "Python Exercises Practice Solution");
```

```csharp
Debug.Assert(RemoveDuplicate("Python Exercises Practice Solution Python") == "Python Exercises Practice Solution");
```

```csharp
Debug.Assert(RemoveDuplicate("Python Exercises Practice Solution Practice") == "Python Exercises Practice Solution");
```
