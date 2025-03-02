# mbcp968 -- Find max value for a periodic function in Python

## Text

Write a C# function to find maximum possible value for the given periodic function.

## Code

```csharp
public static int Floor_Max(int A, int B, int N) {
    int x = Math.Min(B - 1, N);
    return (A * x) / B;
}
```

## Test List

```csharp
Debug.Assert(Floor_Max(11, 10, 9) == 9);
```

```csharp
Debug.Assert(Floor_Max(5, 7, 4) == 2);
```

```csharp
Debug.Assert(Floor_Max(2, 2, 1) == 1);
```
