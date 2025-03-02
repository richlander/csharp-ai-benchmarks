# mbcp-414 -- Check if a value exists in a sequence

## Text

Write a C# function to check whether the value exists in a sequence or not.

## Code

```csharp
public int Overlapping(List<int> list1, List<int> list2)  
{  
    int c = 0;  
    int d = 0;  
    foreach (var i in list1)  
    {  
        c++;  
    }  
    foreach (var i in list2)  
    {  
        d++;  
    }  
    for (int i = 0; i < c; i++)  
    {  
        for (int j = 0; j < d; j++)  
        {  
            if (list1[i] == list2[j])  
            {  
                return 1;  
            }  
        }  
    }  
    return 0;  
}
```

## Test List

```csharp
Debug.Assert(Overlapping(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9 }) == false);
```

```csharp
Debug.Assert(Overlapping(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }) == false);
```

```csharp
Debug.Assert(Overlapping(new int[] { 1, 4, 5 }, new int[] { 1, 4, 5 }) == true);
```
