# mbcp828 -- Count characters types in a given string

## Text

Write a function to count alphabets,digits and special charactes in a given string.

## Code

```csharp
public (int alphabets, int digits, int special) CountAlphaDigSpl(string input)
{
    int alphabets = 0, digits = 0, special = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (char.IsLetter(input[i]))
        {
            alphabets++;
        }
        else if (char.IsDigit(input[i]))
        {
            digits++;
        }
        else
        {
            special++;
        }
    }
    return (alphabets, digits, special);
}
```

## Test List

```csharp
Debug.Assert(CountAlphaDigSpl("abc!@#123").Equals((3, 3, 3)));
```

```csharp
Debug.Assert(CountAlphaDigSpl("dgsuy@#$%&1255") == (5, 4, 5));
```

```csharp
Debug.Assert(CountAlphaDigSpl("fjdsif627348#%$^&") == (6, 6, 5));
```
