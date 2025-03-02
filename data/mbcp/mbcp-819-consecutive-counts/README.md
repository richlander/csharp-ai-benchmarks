# mbcp819 -- Count consecutive duplicates in a list of numbers

## Text

Write a function to count the frequency of consecutive duplicate elements in a given list of numbers.

## Code

```csharp
public (List<int>, List<int>) CountDuplic(List<int> lists)
{
    List<int> element = new List<int>();
    List<int> frequency = new List<int>();
    if (lists.Count == 0)
    {
        return (element, frequency);
    }
    int runningCount = 1;
    for (int i = 0; i < lists.Count - 1; i++)
    {
        if (lists[i] == lists[i + 1])
        {
            runningCount++;
        }
        else
        {
            frequency.Add(runningCount);
            element.Add(lists[i]);
            runningCount = 1;
        }
    }
    frequency.Add(runningCount);
    element.Add(lists[lists.Count - 1]);
    return (element, frequency);
}
```

## Test List

```csharp
Debug.Assert(CountDuplic(new int[] { 1, 2, 2, 2, 4, 4, 4, 5, 5, 5, 5 }) == (new int[] { 1, 2, 4, 5 }, new int[] { 1, 3, 3, 4 }));
```

```csharp
var result = CountDuplic(new List<int> { 2, 2, 3, 1, 2, 6, 7, 9 });
Debug.Assert(result.Equals((new List<int> { 2, 3, 1, 2, 6, 7, 9 }, new List<int> { 2, 1, 1, 1, 1, 1, 1 })));
```

```csharp
Debug.Assert(CountDuplic(new int[] { 2, 1, 5, 6, 8, 3, 4, 9, 10, 11, 8, 12 }).Equals((new int[] { 2, 1, 5, 6, 8, 3, 4, 9, 10, 11, 8, 12 }, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })));
```
