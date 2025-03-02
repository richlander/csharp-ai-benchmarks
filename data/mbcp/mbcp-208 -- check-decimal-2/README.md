# mbcp-208 -- Check decimal format with precision of two using regex

## Text

Write a function to check the given decimal with a precision of 2 by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public static bool IsDecimal(string num)
{
    Regex numFetch = new Regex(@"^[0-9]+(\.[0-9]{1,2})?$");
    Match result = numFetch.Match(num);
    return result.Success;
}
```

## Test List

```csharp
Debug.Assert(IsDecimal("123.11") == true);
```

```csharp
Debug.Assert(IsDecimal("0.21") == true);
```

```csharp
Debug.Assert(IsDecimal("123.1214") == false);
```
