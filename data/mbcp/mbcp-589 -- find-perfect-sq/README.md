# mbcp-589 -- Find perfect squares in a specified range

## Text

Write a function to find perfect squares between two given numbers.

## Code

```csharp
public List<int> PerfectSquares(int a, int b) {
    List<int> lists = new List<int>();
    for (int i = a; i <= b; i++) {
        int j = 1;
        while (j * j <= i) {
            if (j * j == i) {
                lists.Add(i);
            }
            j++;
        }
    }
    return lists;
}
```

## Test List

```csharp
Debug.Assert(PerfectSquares(1, 30).SequenceEqual(new List<int> { 1, 4, 9, 16, 25 }));
```

```csharp
Debug.Assert(PerfectSquares(50, 100).SequenceEqual(new List<int> { 64, 81, 100 }));
```

```csharp
Debug.Assert(PerfectSquares(100, 200).SequenceEqual(new List<int> { 100, 121, 144, 169, 196 }));
```
