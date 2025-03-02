# mbcp725 -- Extract values from quotes using regex in a string

## Text

Write a function to extract values between quotation marks of the given string by using regex.

## Code

```csharp
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class QuotationExtractor
{
    public List<string> ExtractQuotation(string text1)
    {
        return new List<string>(Regex.Matches(text1, "\"(.*?)\"")
                                      .Cast<Match>()
                                      .Select(m => m.Groups[1].Value));
    }
}
```

## Test List

```csharp
Debug.Assert(ExtractQuotation("Cortex \"A53\" Based \"multi\" tasking \"Processor\"").SequenceEqual(new List<string> { "A53", "multi", "Processor" }));
```

```csharp
Debug.Assert(ExtractQuotation("Cast your \"favorite\" entertainment \"apps\"").SequenceEqual(new List<string> { "favorite", "apps" }));
```

```csharp
Debug.Assert(ExtractQuotation("Watch content \"4k Ultra HD\" resolution with \"HDR 10\" Support").SequenceEqual(new List<string> { "4k Ultra HD", "HDR 10" }));
```
