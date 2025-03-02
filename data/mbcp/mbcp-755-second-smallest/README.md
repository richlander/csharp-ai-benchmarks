# mbcp755 -- Find the second smallest number in a list

## Text

Write a function to find the second smallest number in a list.

## Code

```csharp
public int? SecondSmallest(List<int> numbers)
{
    if (numbers.Count < 2)
    {
        return null;
    }
    if (numbers.Count == 2 && numbers[0] == numbers[1])
    {
        return null;
    }
    HashSet<int> dupItems = new HashSet<int>();
    List<int> uniqItems = new List<int>();
    foreach (int x in numbers)
    {
        if (!dupItems.Contains(x))
        {
            uniqItems.Add(x);
            dupItems.Add(x);
        }
    }
    uniqItems.Sort();
    return uniqItems[1];
}
```

## Test List

```csharp
Debug.Assert(SecondSmallest(new int[] { 1, 2, -8, -2, 0, -2 }) == -2);
```

```csharp
Debug.Assert(SecondSmallest(new double[] { 1, 1, -0.5, 0, 2, -2, -2 }) == -0.5);
```

```csharp
Debug.Assert(SecondSmallest(new int[] { 2, 2 }) == null);
```
