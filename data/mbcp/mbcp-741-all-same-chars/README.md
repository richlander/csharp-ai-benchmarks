# mbcp741 -- Check if all characters in a string are the same

## Text

Write a C# function to check whether all the characters are same or not.

## Code

```csharp
public static bool AllCharactersSame(string s) 
{
    int n = s.Length;
    for (int i = 1; i < n; i++) 
    {
        if (s[i] != s[0]) 
        {
            return false;
        }
    }
    return true;
}
```

## Test List

```csharp
Debug.Assert(AllCharactersSame("python") == false);
```

```csharp
Debug.Assert(AllCharactersSame("aaa") == true);
```

```csharp
Debug.Assert(AllCharactersSame("data") == false);
```
