# mbcp303 -- Check if two inversion counts are equal

## Text

Write a C# function to check whether the count of inversion of two types are same or not.

## Code

```csharp
public bool Solve(int[] a, int n)   
{   
    int mx = int.MinValue;   
    for (int j = 1; j < n; j++)   
    {  
        if (mx > a[j])  
        {  
            return false;  
        }  
        mx = Math.Max(mx, a[j - 1]);    
    }  
    return true;  
}
```

## Test List

```csharp
Debug.Assert(Solve(new int[] { 1, 0, 2 }, 3) == true);
```

```csharp
Debug.Assert(Solve(new int[] { 1, 2, 0 }, 3) == false);
```

```csharp
Debug.Assert(Solve(new int[] { 1, 2, 1 }, 3) == true);
```
