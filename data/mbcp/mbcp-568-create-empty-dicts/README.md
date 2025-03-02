# mbcp568 -- Create a list filled with empty dictionaries

## Text

Write a function to create a list of empty dictionaries.

## Code

```csharp
public List<Dictionary<string, object>> EmptyList(int length)  
{  
    var emptyList = new List<Dictionary<string, object>>();  
    for (int i = 0; i < length; i++)  
    {  
        emptyList.Add(new Dictionary<string, object>());  
    }  
    return emptyList;  
}
```

## Test List

```csharp
Debug.Assert(EmptyList(5).SequenceEqual(new List<Dictionary<string, object>> { new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>() }));
```

```csharp
Debug.Assert(EmptyList(6).SequenceEqual(new List<Dictionary<string, object>> { new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>() }));
```

```csharp
Debug.Assert(EmptyList(7).SequenceEqual(new List<Dictionary<string, object>> { new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>(), new Dictionary<string, object>() }));
```
