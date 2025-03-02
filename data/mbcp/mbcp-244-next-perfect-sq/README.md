# mbcp244 -- Find the next perfect square after a number

## Text

Write a C# function to find the next perfect square greater than a given number.

## Code

```csharp
public static int NextPerfectSquare(int N) 
{ 
    int nextN = (int)Math.Floor(Math.Sqrt(N)) + 1; 
    return nextN * nextN; 
}
```

## Test List

```csharp
Debug.Assert(NextPerfectSquare(35) == 36);
```

```csharp
Debug.Assert(NextPerfectSquare(6) == 9);
```

```csharp
Debug.Assert(NextPerfectSquare(9) == 16);
```
