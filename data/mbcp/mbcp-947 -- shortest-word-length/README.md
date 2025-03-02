# mbcp-947 -- Find the length of the shortest word in text

## Text

Write a C# function to find the length of the shortest word.

## Code

```csharp
public int LenLog(List<string> list1)
{
    int min = list1[0].Length;
    foreach (var i in list1)
    {
        if (i.Length < min)
        {
            min = i.Length;
        }
    }
    return min;
}
```

## Test List

```csharp
Debug.Assert(LenLog(new string[] { "win", "lose", "great" }) == 3);
```

```csharp
Debug.Assert(LenLog(new string[] { "a", "ab", "abc" }) == 1);
```

```csharp
Debug.Assert(LenLog(new string[] { "12", "12", "1234" }) == 2);
```
