# mbcp582 -- Check if a dictionary is empty or contains items

## Text

Write a function to check if a dictionary is empty or not.

## Code

```csharp
public bool MyDict(Dictionary<string, object> dict1)
{
    if (dict1.Any())
    {
        return false;
    }
    else
    {
        return true;
    }
}
```

## Test List

```csharp
Debug.Assert(MyDict(new HashSet<int> { 10 }) == false);
```

```csharp
Debug.Assert(MyDict(new HashSet<int> { 11 }) == false);
```

```csharp
Debug.Assert(MyDict(new Dictionary<string, string>()) == true);
```
