# mbcp-647 -- Split a string at each uppercase letter

## Text

Write a function to split a string at uppercase letters.

## Code

```csharp
public List<string> SplitUpperString(string text) 
{
    return Regex.Matches(text, "[A-Z][^A-Z]*")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();
}
```

## Test List

```csharp
Debug.Assert(SplitUpperString("PythonProgramLanguage").SequenceEqual(new List<string> { "Python", "Program", "Language" }));
```

```csharp
Debug.Assert(SplitUpperString("PythonProgram").SequenceEqual(new[] { "Python", "Program" }));
```

```csharp
Debug.Assert(SplitUpperString("ProgrammingLanguage").SequenceEqual(new List<string> { "Programming", "Language" }));
```
