# mbcp-90 -- Find the length of the longest word in a string

## Text

Write a C# function to find the length of the longest word.

## Code

```csharp
public static int LenLog(List<string> list1)
{
    int max = list1[0].Length;
    foreach (var i in list1)
    {
        if (i.Length > max)
        {
            max = i.Length;
        }
    }
    return max;
}
```

## Test List

```csharp
Debug.Assert(LenLog(new string[] { "python", "PHP", "bigdata" }) == 7);
```

```csharp
Debug.Assert(LenLog(new string[] { "a", "ab", "abc" }) == 3);
```

```csharp
Debug.Assert(LenLog(new string[] { "small", "big", "tall" }) == 5);
```
