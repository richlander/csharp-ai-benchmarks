# mbcp942 -- Check if any element exists in the list

## Text

Write a function to check if any list element is present in the given list.

## Code

```csharp
public bool CheckElement(Tuple<int, int> testTup, List<int> checkList)
{
    bool res = false;
    foreach (var ele in checkList)
    {
        if (testTup.Item1 == ele || testTup.Item2 == ele)
        {
            res = true;
            break;
        }
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckElement(new int[] { 4, 5, 7, 9, 3 }, new int[] { 6, 7, 10, 11 }) == true);
```

```csharp
Debug.Assert(CheckElement(new int[] { 1, 2, 3, 4 }, new int[] { 4, 6, 7, 8, 9 }) == true);
```

```csharp
Debug.Assert(CheckElement(new int[] { 3, 2, 1, 4, 5 }, new int[] { 9, 8, 7, 6 }) == false);
```
