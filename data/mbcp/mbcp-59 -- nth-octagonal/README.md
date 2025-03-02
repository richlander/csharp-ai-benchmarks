# mbcp-59 -- Find the nth octagonal number function

## Text

Write a function to find the nth octagonal number.

## Code

```csharp
public static int IsOctagonal(int n) 
{ 
    return 3 * n * n - 2 * n; 
}
```

## Test List

```csharp
Debug.Assert(IsOctagonal(5) == 65);
```

```csharp
Debug.Assert(IsOctagonal(10) == 280);
```

```csharp
Debug.Assert(IsOctagonal(15) == 645);
```
