# mbcp403 -- Validate a URL using regex in a function

## Text

Write a function to check if a url is valid or not using regex.

## Code

```csharp
public static bool IsValidURL(string str) 
{
    string regex = @"((http|https)://)(www\.)?[a-zA-Z0-9@:%._\+~#?&//=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%._\+~#?&//=]*)";
    Regex p = new Regex(regex);
    if (str == null) 
    {
        return false;
    }
    return p.IsMatch(str);
}
```

## Test List

```csharp
Debug.Assert(IsValidURL("https://www.google.com") == true);
```

```csharp
Debug.Assert(IsValidURL("https:/www.gmail.com") == false);
```

```csharp
Debug.Assert(IsValidURL("https:// www.redit.com") == false);
```
