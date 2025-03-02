# mbcp30 -- Count substrings with matching start and end characters

## Text

Write a C# function to count all the substrings starting and ending with same characters.

## Code

```csharp
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

public static bool CheckEquality(string s) 
{
    return (s[0] == s[s.Length - 1]); 
}
```

## Test List

```csharp
Debug.Assert(CheckEquality("abc") == 3);
```

```csharp
CheckEquality(count_Substring_With_Equal_Ends("abcda") == 6);
```

```csharp
Debug.Assert(CheckEquality("ab") == 2);
```
