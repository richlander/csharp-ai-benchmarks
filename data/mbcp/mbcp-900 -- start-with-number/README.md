# mbcp-900 -- Create a string that begins with a given number

## Text

Write a function where a string will start with a specific number.

## Code

```csharp
using System.Text.RegularExpressions;

public bool MatchNum(string str)
{
    Regex regex = new Regex("^5");
    return regex.IsMatch(str);
}
```

## Test List

```csharp
Debug.Assert(MatchNum("5-2345861") == true);
```

```csharp
Debug.Assert(MatchNum("6-2345861") == false);
```

```csharp
Debug.Assert(MatchNum("78910") == false);
```
