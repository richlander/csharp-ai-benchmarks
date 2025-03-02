# mbcp-132 -- Convert a tuple into a string representation

## Text

Write a function to convert tuple to a string.

## Code

```csharp
public string TupString(tuple<string> tup1)
{
    string str = string.Join("", tup1);
    return str;
}
```

## Test List

```csharp
Debug.Assert(TupString(new Tuple<string, string, string, string, string, string, string, string, string>('e', 'x', 'e', 'r', 'c', 'i', 's', 'e', 's')) == "exercises");
```

```csharp
Debug.Assert(TupString(new string[] { "p", "y", "t", "h", "o", "n" }) == "python");
```

```csharp
Debug.Assert(TupString(new Tuple<string, string, string, string, string, string, string>('p', 'r', 'o', 'g', 'r', 'a', 'm')) == "program");
```
