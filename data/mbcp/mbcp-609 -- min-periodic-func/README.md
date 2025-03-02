# mbcp-609 -- Find minimum value of a periodic function in Python

## Text

Write a C# function to find minimum possible value for the given periodic function.

## Code

```csharp
public int FloorMin(int A, int B, int N) {
    int x = Math.Max(B - 1, N);
    return (A * x) / B;
}
```

## Test List

```csharp
Debug.Assert(FloorMin(10, 20, 30) == 15);
```

```csharp
Debug.Assert(FloorMin(1, 2, 1) == 0);
```

```csharp
Debug.Assert(FloorMin(11, 10, 9) == 9);
```
