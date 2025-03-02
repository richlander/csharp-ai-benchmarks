# mbcp679 -- Access dictionary values using key indices

## Text

Write a function to access dictionary key’s element by index.

## Code

```csharp
public static List<string> AccessKey(Dictionary<string, string> dictionary, int key) 
{
    return dictionary.Keys.ToList()[key];
}
```

## Test List

```csharp
Debug.Assert(AccessKey(new Dictionary<string, int>{{"physics", 80}, {"math", 90}, {"chemistry", 86}}, 0) == "physics");
```

```csharp
Debug.Assert(AccessKey(new Dictionary<string, int>{{"python", 10}, {"java", 20}, {"C++", 30}}, 2) == "C++");

public string AccessKey(Dictionary<string, int> keys, int index)
{
    return keys.Keys.ElementAt(index);
}
```

```csharp
Debug.Assert(AccessKey(new Dictionary<string, int>{{"program", 15}, {"computer", 45}}, 1) == "computer");
```
