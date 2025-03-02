# mbcp89 -- Find the nearest smaller number to n

## Text

Write a function to find the closest smaller number than n.

## Code

```csharp
public static int ClosestNum(int N) 
{
    return N - 1;
}
```

## Test List

```csharp
Debug.Assert(ClosestNum(11) == 10);
```

```csharp
Debug.Assert(ClosestNum(7) == 6);
```

```csharp
Debug.Assert(ClosestNum(12) == 11);
```
