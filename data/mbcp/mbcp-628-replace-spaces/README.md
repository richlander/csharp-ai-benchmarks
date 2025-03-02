# mbcp628 -- Replace spaces in a string with %20 characters

## Text

Write a function to replace all spaces in the given string with character * list item * list item * list item * list item '%20'.

## Code

```csharp
MAX = 1000;

public static string ReplaceSpaces(string input)
{
    input = input.Trim();
    int i = input.Length;
    int spaceCount = input.Count(c => c == ' ');
    int newLength = i + spaceCount * 2;

    if (newLength > MAX)
    {
        return "-1";
    }

    int index = newLength - 1;
    List<char> chars = input.ToList();

    for (int f = 0; f < spaceCount * 2; f++)
    {
        chars.Add('0');
    }

    for (int j = i - 1; j >= 0; j--)
    {
        if (chars[j] == ' ')
        {
            chars[index] = '0';
            chars[index - 1] = '2';
            chars[index - 2] = '%';
            index -= 3;
        }
        else
        {
            chars[index] = chars[j];
            index -= 1;
        }
    }

    return new string(chars.ToArray());
}
```

## Test List

```csharp
Debug.Assert(ReplaceSpaces("My Name is Dawood") == "My%20Name%20is%20Dawood");
```

```csharp
Debug.Assert(ReplaceSpaces("I am a Programmer") == "I%20am%20a%20Programmer");
```

```csharp
Debug.Assert(ReplaceSpaces("I love Coding") == "I%20love%20Coding");
```
