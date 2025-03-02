# mbcp933 -- Convert camel case to snake case using regex

## Text

Write a function to convert camel case string to snake case string by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public static string CamelToSnake(string text)
{
    string str1 = Regex.Replace(text, @"(.)([A-Z][a-z]+)", "$1_$2");
    return Regex.Replace(str1, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
}
```

## Test List

```csharp
Debug.Assert(CamelToSnake("GoogleAssistant") == "google_assistant");
```

```csharp
Debug.Assert(CamelToSnake("ChromeCast") == "chrome_cast");
```

```csharp
Debug.Assert(CamelToSnake("QuadCore") == "quad_core");
```
