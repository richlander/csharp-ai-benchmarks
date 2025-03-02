# mbcp-84 -- Find the n-th number in the Newman Conway sequence

## Text

Write a function to find the n-th number in newman conway sequence.

## Code

```csharp
public int Sequence(int n) 
{ 
    if (n == 1 || n == 2) 
    {
        return 1; 
    } 
    else 
    {
        return Sequence(Sequence(n - 1)) + Sequence(n - Sequence(n - 1)); 
    } 
}
```

## Test List

```csharp
Debug.Assert(Sequence(10) == 6);
```

```csharp
Debug.Assert(Sequence(2) == 1);
```

```csharp
Debug.Assert(Sequence(3) == 2);
```
