# mbcp-658 -- Find the most frequent item in a list

## Text

Write a function to find the item with maximum occurrences in a given list.

## Code

```csharp
public static T MaxOccurrences<T>(List<T> list1)
{
    int maxVal = 0;
    T result = list1[0];
    foreach (T i in list1)
    {
        int occu = list1.Count(x => x.Equals(i));
        if (occu > maxVal)
        {
            maxVal = occu;
            result = i;
        }
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(MaxOccurrences(new int[] { 2, 3, 8, 4, 7, 9, 8, 2, 6, 5, 1, 6, 1, 2, 3, 4, 6, 9, 1, 2 }) == 2);

public int MaxOccurrences(int[] numbers) 
{
    // Method implementation goes here
}
```

```csharp
Debug.Assert(MaxOccurrences(new int[] { 1, 3, 5, 7, 1, 3, 13, 15, 17, 5, 7, 9, 1, 11 }) == 1);
```

```csharp
Debug.Assert(MaxOccurrences(new int[] { 1, 2, 3, 2, 4, 5, 1, 1, 1 }) == 1);
```
