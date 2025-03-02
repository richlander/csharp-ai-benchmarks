# mbcp-774 -- Validate email format using regex in a function

## Text

Write a function to check if the string is a valid email address or not using regex.

## Code

```csharp
using System.Text.RegularExpressions;

public class EmailValidator
{
    private static readonly string regex = @"^[a-z0-9]+[\._]?[a-z0-9]+[@]\w+[.]\w{2,3}$";

    public static string CheckEmail(string email)
    {
        if (Regex.IsMatch(email, regex))
        {
            return "Valid Email";
        }
        else
        {
            return "Invalid Email";
        }
    }
}
```

## Test List

```csharp
Debug.Assert(CheckEmail("ankitrai326@gmail.com") == "Valid Email");
```

```csharp
Debug.Assert(CheckEmail("my.ownsite@ourearth.org") == "Valid Email");
```

```csharp
Debug.Assert(CheckEmail("ankitaoie326.com") == "Invalid Email");
```
