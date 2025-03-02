# mbcp834 -- Spiral matrix of squares from 1 to n

## Text

Write a function to generate a square matrix filled with elements from 1 to n raised to the power of 2 in spiral order.

## Code

```csharp
public int[,] GenerateMatrix(int n) {
    if (n <= 0) {
        return new int[0, 0];
    }
    int[,] matrix = new int[n, n];
    int rowSt = 0;
    int rowEd = n - 1;
    int colSt = 0;
    int colEd = n - 1;
    int current = 1;

    while (true) {
        if (current > n * n) {
            break;
        }
        for (int c = colSt; c <= colEd; c++) {
            matrix[rowSt, c] = current;
            current++;
        }
        rowSt++;
        for (int r = rowSt; r <= rowEd; r++) {
            matrix[r, colEd] = current;
            current++;
        }
        colEd--;
        for (int c = colEd; c >= colSt; c--) {
            matrix[rowEd, c] = current;
            current++;
        }
        rowEd--;
        for (int r = rowEd; r >= rowSt; r--) {
            matrix[r, colSt] = current;
            current++;
        }
        colSt++;
    }
    return matrix;
}
```

## Test List

```csharp
Debug.Assert(GenerateMatrix(3).SequenceEqual(new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 8, 9, 4 }, new List<int> { 7, 6, 5 } }));
```

```csharp
Debug.Assert(GenerateMatrix(2).SequenceEqual(new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 4, 3 } }));
```

```csharp
Debug.Assert(GenerateMatrix(7).SequenceEqual(new List<List<int>>() { 
    new List<int>() { 1, 2, 3, 4, 5, 6, 7 }, 
    new List<int>() { 24, 25, 26, 27, 28, 29, 8 }, 
    new List<int>() { 23, 40, 41, 42, 43, 30, 9 }, 
    new List<int>() { 22, 39, 48, 49, 44, 31, 10 }, 
    new List<int>() { 21, 38, 47, 46, 45, 32, 11 }, 
    new List<int>() { 20, 37, 36, 35, 34, 33, 12 }, 
    new List<int>() { 19, 18, 17, 16, 15, 14, 13 } 
}));
```
