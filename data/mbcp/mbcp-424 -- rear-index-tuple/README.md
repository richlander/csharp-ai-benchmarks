# mbcp-424 -- Extract last character from each string in a tuple

## Text

Write a function to extract only the rear index element of each string in the given tuple.

## Code

```csharp
public List<dynamic> ExtractRear(Tuple<dynamic, dynamic>[] testTuple) 
{
    var res = new List<dynamic>();
    foreach (var sub in testTuple)
    {
        res.Add(sub.Item2);
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(ExtractRear(("Mers", "for", "Vers")).SequenceEqual(new List<string> { "s", "r", "s" }));
```

```csharp
Debug.Assert(ExtractRear(("Avenge", "for", "People")).SequenceEqual(new List<char> { 'e', 'r', 'e' }));
```

```csharp
Debug.Assert(ExtractRear(new Tuple<string, string, string>("Gotta", "get", "go")).SequenceEqual(new List<char> { 'a', 't', 'o' }));
```
