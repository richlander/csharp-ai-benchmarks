# mbcp92 -- Check if a number is undulating or not

## Text

Write a function to check whether the given number is undulating or not.

## Code

```csharp
bool IsUndulating(List<int> n) 
{ 
    if (n.Count <= 2) 
    { 
        return false; 
    } 
    for (int i = 2; i < n.Count; i++) 
    { 
        if (n[i - 2] != n[i]) 
        { 
            return false; 
        } 
    } 
    return true; 
}
```

## Test List

```csharp
Debug.Assert(IsUndulating("1212121") == true);
```

```csharp
Debug.Assert(IsUndulating("1991") == false);
```

```csharp
Debug.Assert(IsUndulating("121") == true);
```
