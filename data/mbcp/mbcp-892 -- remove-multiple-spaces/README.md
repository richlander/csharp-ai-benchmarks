# mbcp-892 -- Remove extra spaces from a given string

## Text

Write a function to remove multiple spaces in a string.

## Code

```csharp
public string RemoveSpaces(string text)  
{  
    return Regex.Replace(text, " +", " ");  
}
```

## Test List

```csharp
Debug.Assert(RemoveSpaces("python  program") == "python program");
```

```csharp
Debug.Assert(RemoveSpaces("python   programming    language") == "python programming language");
```

```csharp
Debug.Assert(RemoveSpaces("python                     program") == "python program");
```
