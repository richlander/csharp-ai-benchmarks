# mbcp-492 -- Binary search for an element in an array

## Text

Write a function to search an element in the given array by using binary search.

## Code

```csharp
bool BinarySearch(List<int> itemList, int item)
{
    int first = 0;
    int last = itemList.Count - 1;
    bool found = false;
    while (first <= last && !found)
    {
        int mid = (first + last) / 2;
        if (itemList[mid] == item)
        {
            found = true;
        }
        else
        {
            if (item < itemList[mid])
            {
                last = mid - 1;
            }
            else
            {
                first = mid + 1;
            }
        }
    }
    return found;
}
```

## Test List

```csharp
Debug.Assert(BinarySearch(new int[] { 1, 2, 3, 5, 8 }, 6) == false);
```

```csharp
Debug.Assert(BinarySearch(new int[] { 7, 8, 9, 10, 13 }, 10) == true);
```

```csharp
Debug.Assert(BinarySearch(new int[] { 11, 13, 14, 19, 22, 36 }, 23) == false);
```
