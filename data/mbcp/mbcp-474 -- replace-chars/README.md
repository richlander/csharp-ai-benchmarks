# mbcp-474 -- Replace characters in a string with a function

## Text

Write a function to replace characters in a string.

## Code

```csharp
public string ReplaceChar(string str1, char ch, char newch)  
{  
    string str2 = str1.Replace(ch, newch);  
    return str2;  
}
```

## Test List

```csharp
Debug.Assert(ReplaceChar("polygon", 'y', 'l') == "pollgon");
```

```csharp
Debug.Assert(ReplaceChar("character", 'c', 'a') == "aharaater");
```

```csharp
Debug.Assert(ReplaceChar("python", 'l', 'a') == "python");
```
