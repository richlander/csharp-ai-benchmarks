# mbcp-428 -- Sort an array using the shell sort algorithm

## Text

Write a function to sort the given array by using shell sort.

## Code

```csharp
public List<int> ShellSort(List<int> myList)
{
    int gap = myList.Count / 2;
    while (gap > 0)
    {
        for (int i = gap; i < myList.Count; i++)
        {
            int currentItem = myList[i];
            int j = i;
            while (j >= gap && myList[j - gap] > currentItem)
            {
                myList[j] = myList[j - gap];
                j -= gap;
            }
            myList[j] = currentItem;
        }
        gap /= 2;
    }

    return myList;
}
```

## Test List

```csharp
Debug.Assert(ShellSort(new int[] { 12, 23, 4, 5, 3, 2, 12, 81, 56, 95 }).SequenceEqual(new int[] { 2, 3, 4, 5, 12, 12, 23, 56, 81, 95 }));
```

```csharp
Debug.Assert(ShellSort(new int[] { 24, 22, 39, 34, 87, 73, 68 }).SequenceEqual(new int[] { 22, 24, 34, 39, 68, 73, 87 }));

public static int[] ShellSort(int[] array) {
    int n = array.Length;
    int gap = n / 2;

    while (gap > 0) {
        for (int i = gap; i < n; i++) {
            int temp = array[i];
            int j = i;

            while (j >= gap && array[j - gap] > temp) {
                array[j] = array[j - gap];
                j -= gap;
            }
            array[j] = temp;
        }
        gap /= 2;
    }
    return array;
}
```

```csharp
Debug.Assert(ShellSort(new int[] { 32, 30, 16, 96, 82, 83, 74 }).SequenceEqual(new int[] { 16, 30, 32, 74, 82, 83, 96 }));
```
