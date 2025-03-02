# mbcp-58 -- Check if two integers have opposite signs

## Text

Write a C# function to check whether the given two integers have opposite sign or not.

## Code

```csharp
bool OppositeSigns(int x, int y) 
{ 
    return ((x ^ y) < 0); 
}
```

## Test List

```csharp
Debug.Assert(OppositeSigns(1, -2) == true);
```

```csharp
Debug.Assert(OppositeSigns(3, 2) == false);
```

```csharp
Debug.Assert(OppositeSigns(-10, -10) == false);
```
