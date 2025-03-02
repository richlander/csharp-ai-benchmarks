# mbcp105 -- Count True Booleans in a Given List

## Text

Write a C# function to count true booleans in the given list.

## Code

```csharp
public int Count(List<int> lst)   
{   
    return lst.Sum();   
}
```

## Test List

```csharp
Debug.Assert(Count(new bool[] { true, false, true }) == 2);
```

```csharp
Debug.Assert(Count(new bool[]{ false, false }) == 0);
```

```csharp
Debug.Assert(Count(new List<bool> { true, true, true }) == 3);
```
