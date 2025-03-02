# mbcp-640 -- Remove text inside parentheses from a string

## Text

Write a function to remove the parenthesis area in a string.

## Code

```csharp
public string RemoveParenthesis(List<string> items) 
{
    foreach (var item in items) 
    {
        return Regex.Replace(item, @" ?\([^)]+\)", "");
    }
    return string.Empty; // or handle as needed if no item is found
}
```

## Test List

```csharp
Debug.Assert(RemoveParenthesis(new string[] { "python (chrome)" }) == "python");
```

```csharp
Debug.Assert(RemoveParenthesis(new string[] { "string(.abc)" }) == "string");
```

```csharp
Debug.Assert(RemoveParenthesis(new string[] {"alpha(num)"}) == "alpha");
```
