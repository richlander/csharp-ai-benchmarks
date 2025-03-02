# mbcp352 -- Check if all characters in a string are unique

## Text

Write a C# function to check whether all the characters in a given string are unique.

## Code

```csharp
public bool UniqueCharacters(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = i + 1; j < str.Length; j++)
        {
            if (str[i] == str[j])
            {
                return false;
            }
        }
    }
    return true;
}
```

## Test List

```csharp
Debug.Assert(UniqueCharacters("aba") == false);
```

```csharp
Debug.Assert(UniqueCharacters("abc") == true);
```

```csharp
Debug.Assert(UniqueCharacters("abab") == false);
```
