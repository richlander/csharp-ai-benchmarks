# mbcp-646 -- Count cubes of size k in a larger cube of size n

## Text

Write a C# function to count number of cubes of size k in a cube of size n.

## Code

```csharp
public int NoOfCubes(int N, int K)  
{  
    int No = (N - K + 1);  
    No = (int)Math.Pow(No, 3);  
    return No;  
}
```

## Test List

```csharp
Debug.Assert(NoOfCubes(2, 1) == 8);
```

```csharp
Debug.Assert(NoOfCubes(5, 2) == 64);
```

```csharp
Debug.Assert(NoOfCubes(1, 1) == 1);
```
