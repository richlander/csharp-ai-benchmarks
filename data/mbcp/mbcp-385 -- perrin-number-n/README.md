# mbcp-385 -- Calculate the nth Perrin number recursively

## Text

Write a function to find the n'th perrin number using recursion.

## Code

```csharp
public int GetPerrin(int n) {
    if (n == 0) {
        return 3;
    }
    if (n == 1) {
        return 0;
    }
    if (n == 2) {
        return 2;
    }
    return GetPerrin(n - 2) + GetPerrin(n - 3);
}
```

## Test List

```csharp
Debug.Assert(GetPerrin(9) == 12);
```

```csharp
Debug.Assert(GetPerrin(4) == 2);
```

```csharp
Debug.Assert(GetPerrin(6) == 5);
```
