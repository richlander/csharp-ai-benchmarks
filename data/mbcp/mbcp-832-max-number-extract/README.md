# mbcp832 -- Extract max numeric value from string using regex

## Text

Write a function to extract the maximum numeric value from a string by using regex.

## Code

```csharp
using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static int ExtractMax(string input)
    {
        var numbers = Regex.Matches(input, @"\d+")
                           .Cast<Match>()
                           .Select(m => int.Parse(m.Value));
        return numbers.Max();
    }
}
```

## Test List

```csharp
Debug.Assert(ExtractMax("100klh564abc365bg") == 564);
```

```csharp
Debug.Assert(ExtractMax("hello300how546mer231") == 546);
```

```csharp
Debug.Assert(ExtractMax("its233beenalong343journey234") == 343);
```
