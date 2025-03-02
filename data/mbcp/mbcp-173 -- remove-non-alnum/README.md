# mbcp-173 -- Remove non-alphanumeric characters from a string

## Text

Write a function to remove everything except alphanumeric characters from a string.

## Code

```csharp
public string RemoveSplchar(string text) 
{ 
    var pattern = new Regex(@"[\W_]+");
    return pattern.Replace(text, ""); 
}
```

## Test List

```csharp
Debug.Assert(RemoveSplchar("python  @#&^%$*program123") == "pythonprogram123");
```

```csharp
Debug.Assert(RemoveSplchar("python %^$@!^&*()  programming24%$^^()    language") == "pythonprogramming24language");
```

```csharp
Debug.Assert(RemoveSplchar("python   ^%&^()(+_)(_^&67)                  program") == "python67program");
```
