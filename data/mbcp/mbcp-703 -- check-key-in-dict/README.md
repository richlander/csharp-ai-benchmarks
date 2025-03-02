# mbcp-703 -- Check if a key exists in a dictionary

## Text

Write a function to check whether the given key is present in the dictionary or not.

## Code

```csharp
public bool IsKeyPresent(Dictionary<object, object> d, object x)
{
    if (d.ContainsKey(x))
    {
        return true;
    }
    else
    {
        return false;
    }
}
```

## Test List

```csharp
Debug.Assert(IsKeyPresent(new Dictionary<int, int>{{1, 10}, {2, 20}, {3, 30}, {4, 40}, {5, 50}, {6, 60}}, 5) == true);
```

```csharp
Debug.Assert(IsKeyPresent(new Dictionary<int, int>{{1, 10}, {2, 20}, {3, 30}, {4, 40}, {5, 50}, {6, 60}}, 6) == true);
```

```csharp
Debug.Assert(IsKeyPresent(new Dictionary<int, int> { { 1, 10 }, { 2, 20 }, { 3, 30 }, { 4, 40 }, { 5, 50 }, { 6, 60 } }, 10) == false);
```
