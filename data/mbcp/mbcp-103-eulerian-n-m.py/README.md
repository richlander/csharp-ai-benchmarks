# mbcp103 -- Calculate Eulerian number a(n, m) in a function

## Text

Write a function to find eulerian number a(n, m).

## Code

```csharp
int EulerianNum(int n, int m) 
{ 
    if (m >= n || n == 0) 
        return 0; 
    if (m == 0) 
        return 1; 
    return ((n - m) * EulerianNum(n - 1, m - 1) + (m + 1) * EulerianNum(n - 1, m)); 
}
```

## Test List

```csharp
Debug.Assert(EulerianNum(3, 1) == 4);
```

```csharp
Debug.Assert(EulerianNum(4, 1) == 11);
```

```csharp
Debug.Assert(EulerianNum(5, 3) == 26);
```
