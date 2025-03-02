# mbcp-802 -- Count rotations to sort an array in Python

## Text

Write a C# function to count the number of rotations required to generate a sorted array.

## Code

```csharp
public static int CountRotation(int[] arr, int n)  
{  
    for (int i = 1; i < n; i++)  
    {  
        if (arr[i] < arr[i - 1])  
        {  
            return i;  
        }  
    }  
    return 0;  
}
```

## Test List

```csharp
Debug.Assert(CountRotation(new int[] { 3, 2, 1 }, 3) == 1);
```

```csharp
Debug.Assert(CountRotation(new int[] { 4, 5, 1, 2, 3 }, 5) == 2);
```

```csharp
Debug.Assert(CountRotation(new int[] { 7, 8, 9, 1, 2, 3 }, 6) == 3);
```
