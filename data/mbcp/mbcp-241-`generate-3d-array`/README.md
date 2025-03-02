# mbcp241 -- Create a 3D array filled with asterisks

## Text

Write a function to generate a 3d array having each element as '*'.

## Code

```csharp
public string[][][] Array3D(int m, int n, int o)
{
    string[][][] array3D = new string[o][][];
    for (int row = 0; row < o; row++)
    {
        array3D[row] = new string[n][];
        for (int col = 0; col < n; col++)
        {
            array3D[row][col] = new string[m];
            for (int k = 0; k < m; k++)
            {
                array3D[row][col][k] = "*";
            }
        }
    }
    return array3D;
}
```

## Test List

```csharp
Debug.Assert(Array3D(6, 4, 3).SequenceEqual(new string[][][] {
    new string[][] { new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' } },
    new string[][] { new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' } },
    new string[][] { new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' }, new string[] { '*', '*', '*', '*', '*', '*' } }
}));
```

```csharp
Debug.Assert(Array3D(5, 3, 4).SequenceEqual(new string[][][]
{
    new string[][] { new string[] { "*", "*", "*", "*", "*" }, new string[] { "*", "*", "*", "*", "*" }, new string[] { "*", "*", "*", "*", "*" } },
    new string[][] { new string[] { "*", "*", "*", "*", "*" }, new string[] { "*", "*", "*", "*", "*" }, new string[] { "*", "*", "*", "*", "*" } },
    new string[][] { new string[] { "*", "*", "*", "*", "*" }, new string[] { "*", "*", "*", "*", "*" }, new string[] { "*", "*", "*", "*", "*" } },
    new string[][] { new string[] { "*", "*", "*", "*", "*" }, new string[] { "*", "*", "*", "*", "*" }, new string[] { "*", "*", "*", "*", "*" } }
}));
```

```csharp
Debug.Assert(Array3D(1, 2, 3).SequenceEqual(new List<List<List<string>>> { 
    new List<List<string>> { new List<string> { "*" }, new List<string> { "*" } }, 
    new List<List<string>> { new List<string> { "*" }, new List<string> { "*" } }, 
    new List<List<string>> { new List<string> { "*" }, new List<string> { "*" } } }));
```
