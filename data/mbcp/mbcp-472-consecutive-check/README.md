# mbcp472 -- Check if a list contains consecutive numbers

## Text

Write a C# function to check whether the given list contains consecutive numbers or not.

## Code

```csharp
public bool CheckConsecutive(List<int> l) 
{ 
    return l.OrderBy(x => x).SequenceEqual(Enumerable.Range(l.Min(), l.Max() - l.Min() + 1)); 
}
```

## Test List

```csharp
Debug.Assert(CheckConsecutive(new int[] { 1, 2, 3, 4, 5 }) == true);
```

```csharp
Debug.Assert(CheckConsecutive(new int[] { 1, 2, 3, 5, 6 }) == false);
```

```csharp
Debug.Assert(CheckConsecutive(new int[] { 1, 2, 1 }) == false);
```
