# mbcp54 -- Sort an array using the counting sort algorithm

## Text

Write a function to sort the given array by using counting sort.

## Code

```csharp
public List<int> CountingSort(List<int> myList) 
{
    int maxValue = 0;
    for (int i = 0; i < myList.Count; i++) 
    {
        if (myList[i] > maxValue) 
        {
            maxValue = myList[i];
        }
    }
    int[] buckets = new int[maxValue + 1];
    foreach (int i in myList) 
    {
        buckets[i]++;
    }
    int index = 0;
    for (int j = 0; j <= maxValue; j++) 
    {
        for (int a = 0; a < buckets[j]; a++) 
        {
            myList[index] = j;
            index++;
        }
    }
    return myList;
}
```

## Test List

```csharp
Debug.Assert(CountingSort(new int[] { 1, 23, 4, 5, 6, 7, 8 }).SequenceEqual(new int[] { 1, 4, 5, 6, 7, 8, 23 }));
```

```csharp
Debug.Assert(CountingSort(new int[] { 12, 9, 28, 33, 69, 45 }).SequenceEqual(new int[] { 9, 12, 28, 33, 45, 69 }));
```

```csharp
Debug.Assert(CountingSort(new int[] { 8, 4, 14, 3, 2, 1 }).SequenceEqual(new int[] { 1, 2, 3, 4, 8, 14 }));
```
