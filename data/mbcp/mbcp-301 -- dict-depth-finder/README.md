# mbcp-301 -- Calculate the depth of a nested dictionary structure

## Text

Write a function to find the depth of a dictionary.

## Code

```csharp
public int DictDepth(object d) {
    if (d is Dictionary<string, object>) {
        var dict = (Dictionary<string, object>)d;
        return 1 + (dict.Count > 0 ? dict.Values.Select(DictDepth).Max() : 0);
    }
    return 0;
}
```

## Test List

```csharp
Debug.Assert(DictDepth(new Dictionary<string, object> { {"a", 1}, {"b", new Dictionary<string, object> { {"c", new Dictionary<string, object> { {"d", new Dictionary<string, object>()}}}}}} }) == 4);
```

```csharp
Debug.Assert(DictDepth(new Dictionary<string, object> { { "a", 1 }, { "b", new Dictionary<string, object> { { "c", "python" } } } }) == 2);
```

```csharp
Debug.Assert(DictDepth(new Dictionary<int, object> { { 1, "Sun" }, { 2, new Dictionary<int, object> { { 3, new Dictionary<int, object> { { 4, "Mon" } } } } } }) == 3);
```
