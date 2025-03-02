# mbcp-666 -- Count character occurrences in a given string

## Text

Write a function to count occurrence of a character in a string.

## Code

```csharp
public int CountChar(string str, char ch) 
{
    int count = 0;
    for (int i = 0; i < str.Length; i++) 
    {
        if (str[i] == ch) 
        {
            count++;
        }
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(CountChar("Python", 'o') == 1);
```

```csharp
Debug.Assert(CountChar("little", 't') == 2);
```

```csharp
Debug.Assert(CountChar("assert", 's') == 2);
```
