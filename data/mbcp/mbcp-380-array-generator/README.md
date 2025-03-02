# mbcp380 -- Generate a two-dimensional array using a function

## Text

Write a function to generate a two-dimensional array.

## Code

```csharp
public int[,] MultiList(int rownum, int colnum)
{
    int[,] multiList = new int[rownum, colnum];
    for (int row = 0; row < rownum; row++)
    {
        for (int col = 0; col < colnum; col++)
        {
            multiList[row, col] = row * col;
        }
    }
    return multiList;
}
```

## Test List

```csharp
Debug.Assert(MultiList(3, 4).SequenceEqual(new List<List<int>> { new List<int> { 0, 0, 0, 0 }, new List<int> { 0, 1, 2, 3 }, new List<int> { 0, 2, 4, 6 } }));
```

```csharp
Debug.Assert(MultiList(5, 7).SequenceEqual(new List<List<int>> {
    new List<int> { 0, 0, 0, 0, 0, 0, 0 },
    new List<int> { 0, 1, 2, 3, 4, 5, 6 },
    new List<int> { 0, 2, 4, 6, 8, 10, 12 },
    new List<int> { 0, 3, 6, 9, 12, 15, 18 },
    new List<int> { 0, 4, 8, 12, 16, 20, 24 }
}));
```

```csharp
Debug.Assert(MultiList(10, 15).SequenceEqual(new List<List<int>> {
    new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
    new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 },
    new List<int> { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28 },
    new List<int> { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42 },
    new List<int> { 0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56 },
    new List<int> { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55, 60, 65, 70 },
    new List<int> { 0, 6, 12, 18, 24, 30, 36, 42, 48, 54, 60, 66, 72, 78, 84 },
    new List<int> { 0, 7, 14, 21, 28, 35, 42, 49, 56, 63, 70, 77, 84, 91, 98 },
    new List<int> { 0, 8, 16, 24, 32, 40, 48, 56, 64, 72, 80, 88, 96, 104, 112 },
    new List<int> { 0, 9, 18, 27, 36, 45, 54, 63, 72, 81, 90, 99, 108, 117, 126 }
}));
```
