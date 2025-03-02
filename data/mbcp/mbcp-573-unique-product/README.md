# mbcp573 -- Calculate product of unique list numbers

## Text

Write a C# function to calculate the product of the unique numbers of a given list.

## Code

```csharp
public static int UniqueProduct(List<int> listData) {
    var temp = new HashSet<int>(listData);
    int p = 1;
    foreach (var i in temp) {
        p *= i;
    }
    return p;
}
```

## Test List

```csharp
Debug.Assert(UniqueProduct(new List<int> { 10, 20, 30, 40, 20, 50, 60, 40 }) == 720000000);
```

```csharp
Debug.Assert(UniqueProduct(new int[] { 1, 2, 3, 1 }) == 6);
```

```csharp
Debug.Assert(UniqueProduct(new int[] { 7, 8, 9, 0, 1, 1 }) == 0);
```
