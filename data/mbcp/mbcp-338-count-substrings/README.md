# mbcp338 -- Count substrings with matching first and last chars

## Text

Write a C# function to count the number of substrings with same first and last characters.

## Code

```csharp
public static bool CheckEquality(string s) 
{
    return (s[0] == s[s.Length - 1]);
}

public static int CountSubstringWithEqualEnds(string s) 
{
    int result = 0; 
    int n = s.Length; 
    for (int i = 0; i < n; i++) 
    {
        for (int j = 1; j <= n - i; j++) 
        {
            if (CheckEquality(s.Substring(i, j))) 
            {
                result++;
            }
        }
    }
    return result; 
}
```

## Test List

```csharp
Debug.Assert(CountSubstringWithEqualEnds("aba") == 4);
```

```csharp
Debug.Assert(CountSubstringWithEqualEnds("abcab") == 7);
```

```csharp
Debug.Assert(CountSubstringWithEqualEnds("abc") == 3);
```
