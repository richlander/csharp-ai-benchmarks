# mbcp-102 -- Convert snake case to camel case string

## Text

Write a function to convert snake case string to camel case string.

## Code

```csharp
public string SnakeToCamel(string word)
{
    return string.Concat(word.Split('_').Select(x => char.ToUpper(x[0]) + x.Substring(1)));
}
```

## Test List

```csharp
Debug.Assert(SnakeToCamel("python_program") == "PythonProgram");
```

```csharp
Debug.Assert(SnakeToCamel("python_language") == "PythonLanguage");
```

```csharp
Debug.Assert(SnakeToCamel("programming_language") == "ProgrammingLanguage");
```
