# mbcp-354 -- Find t-nth term in arithmetic progression

## Text

Write a function to find t-nth term of arithemetic progression.

## Code

```csharp
public static int TnAp(int a, int n, int d) 
{
    int tn = a + (n - 1) * d;
    return tn;
}
```

## Test List

```csharp
Debug.Assert(TnAp(1, 5, 2) == 9);
```

```csharp
Debug.Assert(TnAp(2, 6, 4) == 22);
```

```csharp
Debug.Assert(TnAp(1, 4, 5) == 16);
```
