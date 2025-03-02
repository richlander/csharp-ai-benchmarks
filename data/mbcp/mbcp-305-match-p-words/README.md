# mbcp305 -- Find two words starting with P from a list

## Text

Write a function to match two words from a list of words starting with letter 'p'.

## Code

```csharp
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class Example
{
    public static (string, string) StartWithP(List<string> words)
    {
        foreach (var w in words)
        {
            var m = Regex.Match(w, @"(P\w+)\W(P\w+)");
            if (m.Success)
            {
                return (m.Groups[1].Value, m.Groups[2].Value);
            }
        }
        return (null, null);
    }
}
```

## Test List

```csharp
Debug.Assert(StartWithP(new string[] { "Python PHP", "Java JavaScript", "c c++" }) == ("Python", "PHP"));

public static (string, string) StartWithP(string[] input)
{
    // Method implementation goes here
}
```

```csharp
Debug.Assert(StartWithP(new string[] { "Python Programming", "Java Programming" }) == Tuple.Create("Python", "Programming"));
```

```csharp
Debug.Assert(StartWithP(new string[] { "Pqrst Pqr", "qrstuv" }) == (("Pqrst", "Pqr")));
```
