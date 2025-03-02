# mbcp-538 -- Convert string list to a tuple in Python

## Text

Write a C# function to convert a given string list to a tuple.

## Code

```csharp
public static Tuple<char>[] StringListToTuple(string str1)
{
    var result = str1.Where(x => !char.IsWhiteSpace(x)).Select(x => x).ToArray();
    return result;
}
```

## Test List

```csharp
Debug.Assert(StringListToTuple(new string[] { "python 3.0" }).Equals(Tuple.Create('p', 'y', 't', 'h', 'o', 'n', '3', '.', '0')));
```

```csharp
Debug.Assert(StringListToTuple("bigdata").Equals(Tuple.Create('b', 'i', 'g', 'd', 'a', 't', 'a')));
```

```csharp
Debug.Assert(StringListToTuple("language").Equals(('l', 'a', 'n', 'g', 'u', 'a', 'g', 'e')));
```
