# mbcp-254 -- Find words starting with a or e in a string

## Text

Write a function to find all words starting with 'a' or 'e' in a given string.

## Code

```csharp
public List<string> WordsAe(string text)
{
    return Regex.Matches(text, @"[ae]\w+").Cast<Match>().Select(m => m.Value).ToList();
}
```

## Test List

```csharp
Debug.Assert(WordsAe("python programe").SequenceEqual(new List<string> { "ame" }));
```

```csharp
Debug.Assert(WordsAe("python programe language").SequenceEqual(new List<string> { "ame", "anguage" }));
```

```csharp
Debug.Assert(WordsAe("assert statement").SequenceEqual(new List<string> { "assert", "atement" }));
```
