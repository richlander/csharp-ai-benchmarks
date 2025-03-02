# mbcp427 -- Convert date format from yyyy-mm-dd to dd-mm-yyyy

## Text

Write a function to convert a date of yyyy-mm-dd format to dd-mm-yyyy format by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public string ChangeDateFormat(string dt)
{
    return Regex.Replace(dt, @"(\d{4})-(\d{1,2})-(\d{1,2})", "$3-$2-$1");
}
```

## Test List

```csharp
Debug.Assert(ChangeDateFormat("2026-01-02") == "02-01-2026");
```

```csharp
Debug.Assert(ChangeDateFormat("2020-11-13") == "13-11-2020");
```

```csharp
Debug.Assert(ChangeDateFormat("2021-04-26") == "26-04-2021");
```
