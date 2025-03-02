# mbcp236 -- Count triangles in a given equilateral triangle

## Text

Write a C# function to count the maximum number of equilateral triangles that can be formed within a given equilateral triangle.

## Code

```csharp
public static int NoOfTriangle(int N, int K) 
{
    if (N < K) 
    {
        return -1;
    } 
    else 
    {
        int Tri_up = ((N - K + 1) * (N - K + 2)) / 2;
        int Tri_down = ((N - 2 * K + 1) * (N - 2 * K + 2)) / 2;
        return Tri_up + Tri_down;
    }
}
```

## Test List

```csharp
Debug.Assert(NoOfTriangle(4, 2) == 7);
```

```csharp
Debug.Assert(NoOfTriangle(4, 3) == 3);
```

```csharp
Debug.Assert(NoOfTriangle(1, 3) == -1);
```
