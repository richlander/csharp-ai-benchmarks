# mbcp-360 -- Find the n’th carol number in sequence

## Text

Write a function to find the n’th carol number.

## Code

```csharp
public int GetCarol(int n) 
{ 
    int result = (int)Math.Pow(2, n) - 1; 
    return result * result - 2; 
}
```

## Test List

```csharp
Debug.Assert(GetCarol(2) == 7);
```

```csharp
Debug.Assert(GetCarol(4) == 223);
```

```csharp
Debug.Assert(GetCarol(5) == 959);
```
