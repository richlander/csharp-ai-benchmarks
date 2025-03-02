# mbcp421 -- Concatenate tuple elements using a specified delimiter

## Text

Write a function to concatenate each element of tuple by the delimiter.

## Code

```csharp
public static string ConcatenateTuple(Tuple<string, string> testTup)
{
    string delim = "-";
    string res = string.Join(delim, testTup);
    res = res.Substring(0, res.Length - delim.Length);
    return res;
}
```

## Test List

```csharp
Debug.Assert(ConcatenateTuple(("ID", "is", 4, "UTS")) == "ID-is-4-UTS");
```

```csharp
Debug.Assert(ConcatenateTuple(("QWE", "is", 4, "RTY")) == "QWE-is-4-RTY");
```

```csharp
Debug.Assert(ConcatenateTuple(("ZEN", "is", 4, "OP")) == "ZEN-is-4-OP");

public string ConcatenateTuple((string, string, int, string) tuple)
{
    return string.Join("-", tuple.Item1, tuple.Item2, tuple.Item3.ToString(), tuple.Item4);
}
```
