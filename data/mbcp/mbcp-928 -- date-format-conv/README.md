# mbcp-928 -- Convert date from yyyy-mm-dd to dd-mm-yyyy format

## Text

Write a function to convert a date of yyyy-mm-dd format to dd-mm-yyyy format.

## Code

```csharp
using System.Text.RegularExpressions;

public class DateFormatter
{
    public string ChangeDateFormat(string dt)
    {
        return Regex.Replace(dt, @"(\d{4})-(\d{1,2})-(\d{1,2})", "$3-$2-$1");
    }
}
```

## Test List

```csharp
Debug.Assert(ChangeDateFormat("2026-01-02") == "02-01-2026");
```

```csharp
Debug.Assert(ChangeDateFormat("2021-01-04") == "04-01-2021");
```

```csharp
Debug.Assert(ChangeDateFormat("2030-06-06") == "06-06-2030");
```
