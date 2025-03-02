# mbcp450 -- Extract strings of specified size from a list

## Text

Write a function to extract specified size of strings from a give list of string values.

## Code

```csharp
public List<string> ExtractString(string str, int l) 
{
    return str.Where(e => e.Length == l).ToList();
}
```

## Test List

```csharp
Debug.Assert(ExtractString(new List<string> { "Python", "list", "exercises", "practice", "solution" }, 8).SequenceEqual(new List<string> { "practice", "solution" }));
```

```csharp
Debug.Assert(ExtractString(new List<string> { "Python", "list", "exercises", "practice", "solution" }, 6).SequenceEqual(new List<string> { "Python" }));
```

```csharp
Debug.Assert(ExtractString(new List<string> { "Python", "list", "exercises", "practice", "solution" }, 9).SequenceEqual(new List<string> { "exercises" }));
```
