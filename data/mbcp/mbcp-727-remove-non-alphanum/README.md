# mbcp727 -- Remove non-alphanumeric characters with regex

## Text

Write a function to remove all characters except letters and numbers using regex

## Code

```csharp
using System.Text.RegularExpressions;

public string RemoveChar(string S)
{
    string result = Regex.Replace(S, @"[\W_]+", "");
    return result;
}
```

## Test List

```csharp
Debug.Assert(RemoveChar("123abcjw:, .@! eiw") == "123abcjweiw");
```

```csharp
Debug.Assert(RemoveChar("Hello1234:, ! Howare33u") == "Hello1234Howare33u");
```

```csharp
Debug.Assert(RemoveChar("Cool543Triks@:, Make@987Trips") == "Cool543TriksMake987Trips");
```
