# mbcp-459 -- Remove uppercase substrings from a string using regex

## Text

Write a function to remove uppercase substrings from a given string by using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public string RemoveUppercase(string str1)
{
    Func<string, string> removeUpper = text => Regex.Replace(text, "[A-Z]", "");
    string result = removeUpper(str1);
    return result;
}
```

## Test List

```csharp
Debug.Assert(RemoveUppercase("cAstyoUrFavoRitETVshoWs") == "cstyoravoitshos");

public string RemoveUppercase(string input)
{
    return new string(input.Where(c => !char.IsUpper(c)).ToArray());
}
```

```csharp
Debug.Assert(RemoveUppercase("wAtchTheinTernEtrAdIo") == "wtchheinerntrdo");
```

```csharp
Debug.Assert(RemoveUppercase("VoicESeaRchAndreComMendaTionS") == "oiceachndreomendaion");
```
