# mbcp-394 -- Check if elements in a tuple are distinct

## Text

Write a function to check if given tuple is distinct or not.

## Code

```csharp
public static bool CheckDistinct(Tuple<int>[] testTup)
{
    bool res = true;
    HashSet<int> temp = new HashSet<int>();
    foreach (var ele in testTup)
    {
        if (temp.Contains(ele.Item1))
        {
            res = false;
            break;
        }
        temp.Add(ele.Item1);
    }
    return res;
}
```

## Test List

```csharp
Debug.Assert(CheckDistinct(new int[] { 1, 4, 5, 6, 1, 4 }) == false);
```

```csharp
Debug.Assert(CheckDistinct(new int[] { 1, 4, 5, 6 }) == true);
```

```csharp
Debug.Assert(CheckDistinct(new int[] { 2, 3, 4, 5, 6 }) == true);
```
