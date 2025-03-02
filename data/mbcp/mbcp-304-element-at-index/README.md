# mbcp304 -- Find element at index after rotations in Python

## Text

Write a C# function to find element at a given index after number of rotations.

## Code

```csharp
public int FindElement(int[] arr, int[][] ranges, int rotations, int index) 
{ 
    for (int i = rotations - 1; i >= 0; i--) 
    { 
        int left = ranges[i][0]; 
        int right = ranges[i][1]; 
        if (left <= index && right >= index) 
        { 
            if (index == left) 
            { 
                index = right; 
            } 
            else 
            { 
                index = index - 1; 
            } 
        } 
    } 
    return arr[index]; 
}
```

## Test List

```csharp
Debug.Assert(FindElement(new int[] { 1, 2, 3, 4, 5 }, new int[][] { new int[] { 0, 2 }, new int[] { 0, 3 } }, 2, 1) == 3);
```

```csharp
Debug.Assert(FindElement(new int[] { 1, 2, 3, 4 }, new int[,] { { 0, 1 }, { 0, 2 } }, 1, 2) == 3);
```

```csharp
Debug.Assert(FindElement(new int[] { 1, 2, 3, 4, 5, 6 }, new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 } }, 1, 1) == 1);
```
