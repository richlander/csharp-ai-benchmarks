# mbcp-925 -- Calculate the product of numbers in a tuple

## Text

Write a C# function to calculate the product of all the numbers of a given tuple.

## Code

```csharp
public int MultipleTuple(IEnumerable<int> nums) {
    var temp = nums.ToList();
    int product = 1; 
    foreach (var x in temp) {
        product *= x;
    }
    return product;
}
```

## Test List

```csharp
Debug.Assert(MultipleTuple(new Tuple<int, int, int, int, int, int>(4, 3, 2, 2, -1, 18)) == -864);
```

```csharp
Debug.Assert(MultipleTuple((1, 2, 3)) == 6);
```

```csharp
Debug.Assert(MultipleTuple((-2, -4, -6)) == -48);
```
