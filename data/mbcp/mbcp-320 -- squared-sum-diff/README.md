# mbcp-320 -- Calculate difference of squared sums and sums squared

## Text

Write a function to calculate the difference between the squared sum of first n natural numbers and the sum of squared first n natural numbers.

## Code

```csharp
public int SumDifference(int n) {
    int sumofsquares = 0;
    int squareofsum = 0;
    for (int num = 1; num <= n; num++) {
        sumofsquares += num * num;
        squareofsum += num;
    }
    squareofsum = squareofsum * squareofsum;
    return squareofsum - sumofsquares;
}
```

## Test List

```csharp
Debug.Assert(SumDifference(12) == 5434);
```

```csharp
Debug.Assert(SumDifference(20) == 41230);
```

```csharp
Debug.Assert(SumDifference(54) == 2151270);
```
