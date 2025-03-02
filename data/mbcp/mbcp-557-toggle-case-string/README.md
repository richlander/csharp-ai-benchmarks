# mbcp557 -- Toggle the case of each character in a string

## Text

Write a function to toggle characters case in a string.

## Code

```csharp
public string ToggleString(string input)
{
    string result = string.Empty;

    foreach (char c in input)
    {
        if (char.IsUpper(c))
        {
            result += char.ToLower(c);
        }
        else if (char.IsLower(c))
        {
            result += char.ToUpper(c);
        }
        else
        {
            result += c;
        }
    }

    return result;
}
```

## Test List

```csharp
Debug.Assert(ToggleString("Python") == "pYTHON");
```

```csharp
Debug.Assert(ToggleString("Pangram") == "pANGRAM");
```

```csharp
Debug.Assert(ToggleString("LIttLE") == "liTTle");
```
