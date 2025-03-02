# mbcp965 -- Convert camel case to snake case string

## Text

Write a function to convert camel case string to snake case string.

## Code

```csharp
public static string CamelToSnake(string text)
{
    var str1 = Regex.Replace(text, @"(.)([A-Z][a-z]+)", "$1_$2");
    return Regex.Replace(str1, "([a-z0-9])([A-Z])", "$1_$2").ToLower();
}
```

## Test List

```csharp
Debug.Assert(CamelToSnake("PythonProgram") == "python_program");
```

```csharp
Debug.Assert(CamelToSnake("pythonLanguage") == "python_language");
```

```csharp
Debug.Assert(CamelToSnake("ProgrammingLanguage") == "programming_language");
```
