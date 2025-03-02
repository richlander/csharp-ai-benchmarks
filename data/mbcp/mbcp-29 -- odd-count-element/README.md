# mbcp-29 -- Find element with odd occurrences in a list

## Text

Write a C# function to find the element occurring odd number of times.

## Code

```csharp
public int GetOddOccurrence(int[] arr, int arrSize)
{
    for (int i = 0; i < arrSize; i++)
    {
        int count = 0;
        for (int j = 0; j < arrSize; j++)
        {
            if (arr[i] == arr[j])
            {
                count++;
            }
        }
        if (count % 2 != 0)
        {
            return arr[i];
        }
    }
    return -1;
}
```

## Test List

```csharp
Debug.Assert(GetOddOccurrence(new int[] { 1, 2, 3, 1, 2, 3, 1 }, 7) == 1);
```

```csharp
Debug.Assert(GetOddOccurrence(new int[] { 1, 2, 3, 2, 3, 1, 3 }, 7) == 3);
```

```csharp
Debug.Assert(GetOddOccurrence(new int[] { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 }, 13) == 5);
```
