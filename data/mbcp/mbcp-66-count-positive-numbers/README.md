# mbcp66 -- Count positive numbers in a list using Python

## Text

Write a C# function to count positive numbers in a list.

## Code

```csharp
public int PosCount(List<int> list)  
{  
    int posCount = 0;  
    foreach (int num in list)  
    {  
        if (num >= 0)  
        {  
            posCount++;  
        }  
    }  
    return posCount;  
}
```

## Test List

```csharp
Debug.Assert(PosCount(new int[] { 1, -2, 3, -4 }) == 2);
```

```csharp
Debug.Assert(PosCount(new int[] { 3, 4, 5, -1 }) == 3);
```

```csharp
Debug.Assert(PosCount(new List<int> { 1, 2, 3, 4 }) == 4);
```
