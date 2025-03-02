# mbcp-684 -- Count character occurrences in a repeated string

## Text

Write a C# function to count occurences of a character in a repeated string.

## Code

```csharp
public int CountChar(string str, char x) 
{
    int count = 0;
    for (int i = 0; i < str.Length; i++) 
    {
        if (str[i] == x) 
        {
            count++;
        }
    }
    int n = 10;
    int repititions = n / str.Length;
    count = count * repititions;
    int l = n % str.Length;
    for (int i = 0; i < l; i++) 
    {
        if (str[i] == x) 
        {
            count++;
        }
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(CountChar("abcac", 'a') == 4);
```

```csharp
Debug.Assert(CountChar("abca", 'c') == 2);
```

```csharp
Debug.Assert(CountChar("aba", 'a') == 7);
```
