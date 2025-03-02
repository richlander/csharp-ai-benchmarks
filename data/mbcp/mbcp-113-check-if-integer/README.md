# mbcp113 -- Check if a string is an integer representation

## Text

Write a function to check if a string represents an integer or not.

## Code

```csharp
public bool CheckInteger(string text)
{
    text = text.Trim();
    if (text.Length < 1)
    {
        return false;
    }
    else
    {
        if (text.All(c => "0123456789".Contains(c)))
        {
            return true;
        }
        else if ((text[0] == '+' || text[0] == '-') && 
                 text.Substring(1).All(c => "0123456789".Contains(c)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
```

## Test List

```csharp
Debug.Assert(CheckInteger("python") == false);
```

```csharp
Debug.Assert(CheckInteger("1") == true);
```

```csharp
Debug.Assert(CheckInteger("12345") == true);
```
