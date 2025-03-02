# mbcp-129 -- Create a function to compute magic square values

## Text

Write a function to calculate magic square.

## Code

```csharp
public static bool MagicSquareTest(int[][] myMatrix) {
    int iSize = myMatrix[0].Length;
    List<int> sumList = new List<int>();
    sumList.AddRange(myMatrix.Select(lines => lines.Sum()));
    
    for (int col = 0; col < iSize; col++) {
        sumList.Add(myMatrix.Sum(row => row[col]));
    }
    
    int result1 = 0;
    for (int i = 0; i < iSize; i++) {
        result1 += myMatrix[i][i];
    }
    sumList.Add(result1);
    
    int result2 = 0;
    for (int i = iSize - 1; i >= 0; i--) {
        result2 += myMatrix[i][i];
    }
    sumList.Add(result2);
    
    return sumList.Distinct().Count() <= 1;
}
```

## Test List

```csharp
Debug.Assert(MagicSquareTest(new int[,] { { 7, 12, 1, 14 }, { 2, 13, 8, 11 }, { 16, 3, 10, 5 }, { 9, 6, 15, 4 } }) == true);
```

```csharp
Debug.Assert(MagicSquareTest(new int[,] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } }) == true);
```

```csharp
Debug.Assert(MagicSquareTest(new int[,] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 7 } }) == false);
```
