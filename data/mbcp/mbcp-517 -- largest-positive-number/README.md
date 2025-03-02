# mbcp-517 -- Find the largest positive number in a list

## Text

Write a C# function to find the largest postive number from the given list.

## Code

```csharp
public int LargestPos(List<int> list1) 
{
    int max = list1[0]; 
    foreach (int x in list1) 
    {
        if (x > max) 
        {
            max = x; 
        }
    }
    return max;
}
```

## Test List

```csharp
Debug.Assert(LargestPos(new int[] { 1, 2, 3, 4, -1 }) == 4);
```

```csharp
Debug.Assert(LargestPos(new int[] { 0, 1, 2, -5, -1, 6 }) == 6);
```

```csharp
Debug.Assert(LargestPos(new int[] { 0, 0, 1, 0 }) == 1);
```
