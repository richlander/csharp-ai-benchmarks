# mbcp-700 -- Count elements in a list within a specific range

## Text

Write a function to count the number of elements in a list which are within a specific range.

## Code

```csharp
public int CountRangeInList(List<int> li, int min, int max)
{
    int ctr = 0;
    foreach (int x in li)
    {
        if (min <= x && x <= max)
        {
            ctr++;
        }
    }
    return ctr;
}
```

## Test List

```csharp
Debug.Assert(CountRangeInList(new List<int> { 10, 20, 30, 40, 40, 40, 70, 80, 99 }, 40, 100) == 6);
```

```csharp
Debug.Assert(CountRangeInList(new List<string> { "a", "b", "c", "d", "e", "f" }, "a", "e") == 5);
```

```csharp
Debug.Assert(CountRangeInList(new List<int> { 7, 8, 9, 15, 17, 19, 45 }, 15, 20) == 3);
```
