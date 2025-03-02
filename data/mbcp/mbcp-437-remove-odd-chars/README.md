# mbcp437 -- Remove odd-indexed characters from a string

## Text

Write a function to remove odd characters in a string.

## Code

```csharp
public string RemoveOdd(string str1)
{
    string str2 = "";
    for (int i = 1; i <= str1.Length; i++)
    {
        if (i % 2 == 0)
        {
            str2 += str1[i - 1];
        }
    }
    return str2;
}
```

## Test List

```csharp
Debug.Assert(RemoveOdd("python") == "yhn");
```

```csharp
Debug.Assert(RemoveOdd("program") == "rga");
```

```csharp
Debug.Assert(RemoveOdd("language") == "agae");
```
