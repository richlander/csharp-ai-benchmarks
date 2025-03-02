# mbcp713 -- Check if a tuple contains all valid values

## Text

Write a function to check if the given tuple contains all valid values or not.

## Code

```csharp
public bool CheckValid(IEnumerable<bool> testTup)
{
    bool res = !testTup.Any(ele => !ele);
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckValid(new Tuple<bool, bool, bool, bool>(true, true, true, true)) == true);
```

```csharp
Debug.Assert(CheckValid(new Tuple<bool, bool, bool, bool>(true, false, true, true)) == false);
```

```csharp
Debug.Assert(CheckValid(new Tuple<bool, bool, bool, bool>(true, true, true, true)) == true);
```
