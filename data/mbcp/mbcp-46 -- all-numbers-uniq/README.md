# mbcp-46 -- Check if all numbers in a list are unique

## Text

Write a C# function to determine whether all the numbers are different from each other are not.

## Code

```csharp
public bool TestDistinct(IEnumerable<int> data)
{
    return data.Count() == data.Distinct().Count();
}
```

## Test List

```csharp
Debug.Assert(TestDistinct(new int[] { 1, 5, 7, 9 }) == true);
```

```csharp
Debug.Assert(TestDistinct(new int[] { 2, 4, 5, 5, 7, 9 }) == false);
```

```csharp
Debug.Assert(TestDistinct(new int[] { 1, 2, 3 }) == true);
```
