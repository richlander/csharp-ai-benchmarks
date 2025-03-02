# mbcp-806 -- Find longest sequence of uppercase letters in string

## Text

Write a function to find maximum run of uppercase characters in the given string.

## Code

```csharp
public static int MaxRunUppercase(string testStr) 
{
    int cnt = 0;
    int res = 0;
    for (int idx = 0; idx < testStr.Length; idx++) 
    {
        if (char.IsUpper(testStr[idx])) 
        {
            cnt++;
        } 
        else 
        {
            res = cnt;
            cnt = 0;
        }
    }
    if (char.IsUpper(testStr[testStr.Length - 1])) 
    {
        res = cnt;
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(MaxRunUppercase("GeMKSForGERksISBESt") == 5);
```

```csharp
Debug.Assert(MaxRunUppercase("PrECIOusMOVemENTSYT") == 6);
```

```csharp
Debug.Assert(MaxRunUppercase("GooGLEFluTTER") == 4);
```
