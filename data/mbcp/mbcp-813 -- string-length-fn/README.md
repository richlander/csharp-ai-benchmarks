# mbcp-813 -- Find the length of a given string

## Text

Write a function to find length of the string.

## Code

```csharp
public int StringLength(string str1)
{
    int count = 0;
    foreach (char c in str1)
    {
        count += 1;
    }
    return count;
}
```

## Test List

```csharp
Debug.Assert(StringLength("python") == 6);
```

```csharp
Debug.Assert(StringLength("program") == 7);
```

```csharp
Debug.Assert(StringLength("language") == 8);
```
