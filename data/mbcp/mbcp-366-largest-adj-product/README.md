# mbcp366 -- Find largest product of adjacent integers in a list

## Text

Write a C# function to find the largest product of the pair of adjacent elements from a given list of integers.

## Code

```csharp
public static int AdjacentNumProduct(List<int> listNums)
{
    return listNums.Zip(listNums.Skip(1), (a, b) => a * b).Max();
}
```

## Test List

```csharp
Debug.Assert(AdjacentNumProduct(new int[] { 1, 2, 3, 4, 5, 6 }) == 30);
```

```csharp
Debug.Assert(AdjacentNumProduct(new int[] { 1, 2, 3, 4, 5 }) == 20);
```

```csharp
Debug.Assert(AdjacentNumProduct(new int[] { 2, 3 }) == 6);
```
