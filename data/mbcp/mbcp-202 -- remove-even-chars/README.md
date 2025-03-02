# mbcp-202 -- Remove even-indexed characters from a string

## Text

Write a function to remove even characters in a string.

## Code

```csharp
public string RemoveEven(string str1) 
{
    string str2 = string.Empty;
    for (int i = 1; i <= str1.Length; i++) 
    {
        if (i % 2 != 0) 
        {
            str2 += str1[i - 1];
        }
    }
    return str2;
}
```

## Test List

```csharp
Debug.Assert(RemoveEven("python") == "pto");
```

```csharp
Debug.Assert(RemoveEven("program") == "porm");
```

```csharp
Debug.Assert(RemoveEven("language") == "lnug");
```
