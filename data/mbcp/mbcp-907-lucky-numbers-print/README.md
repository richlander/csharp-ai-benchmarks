# mbcp907 -- Print the first n lucky numbers in a function

## Text

Write a function to print the first n lucky numbers.

## Code

```csharp
public List<int> LuckyNum(int n) {
    List<int> List = Enumerable.Range(-1, n * n + 9).Where(x => x % 2 == 0).ToList();
    int i = 2;
    while (List.Skip(i).Any()) {
        List = List.Distinct().Except(List.Skip(i).SelectMany(x => List.SkipWhile(y => y % x == 0))).ToList();
        i++;
    }
    return List.Skip(1).Take(n).ToList();
}
```

## Test List

```csharp
Debug.Assert(LuckyNum(10).SequenceEqual(new List<int> { 1, 3, 7, 9, 13, 15, 21, 25, 31, 33 }));
```

```csharp
Debug.Assert(LuckyNum(5).SequenceEqual(new List<int> { 1, 3, 7, 9, 13 }));
```

```csharp
Debug.Assert(LuckyNum(8).SequenceEqual(new List<int> { 1, 3, 7, 9, 13, 15, 21, 25 }));
```
