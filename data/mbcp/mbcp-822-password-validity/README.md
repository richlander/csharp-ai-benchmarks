# mbcp822 -- Validate a password and return true if valid

## Text

Write a function to return true if the password is valid.

## Code

```csharp
using System.Text.RegularExpressions;

public bool PassValidity(string p) 
{
    bool x = true;
    while (x) 
    {
        if (p.Length < 6 || p.Length > 12)
        {
            break;
        }
        else if (!Regex.IsMatch(p, "[a-z]"))
        {
            break;
        }
        else if (!Regex.IsMatch(p, "[0-9]"))
        {
            break;
        }
        else if (!Regex.IsMatch(p, "[A-Z]"))
        {
            break;
        }
        else if (!Regex.IsMatch(p, "[$#@]"))
        {
            break;
        }
        else if (Regex.IsMatch(p, "\\s"))
        {
            break;
        }
        else 
        {
            return true;
        }

        x = false;
        break;
    }

    return false;
}
```

## Test List

```csharp
Debug.Assert(PassValidity("password") == false);
```

```csharp
Debug.Assert(PassValidity("Password@10") == true);
```

```csharp
Debug.Assert(PassValidity("password@10") == false);
```
