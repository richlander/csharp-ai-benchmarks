# mbcp659 -- Find and print duplicates in a list of integers

## Text

Write a C# function to print duplicants from a list of integers.

## Code

```csharp
public List<T> Repeat<T>(List<T> x) 
{
    int _size = x.Count; 
    List<T> repeated = new List<T>(); 
    for (int i = 0; i < _size; i++) 
    {
        int k = i + 1; 
        for (int j = k; j < _size; j++) 
        {
            if (EqualityComparer<T>.Default.Equals(x[i], x[j]) && !repeated.Contains(x[i])) 
            {
                repeated.Add(x[i]); 
            }
        }
    }
    return repeated; 
}
```

## Test List

```csharp
Debug.Assert(Repeat(new List<int> { 10, 20, 30, 20, 20, 30, 40, 50, -20, 60, 60, -20, -20 }).SequenceEqual(new List<int> { 20, 30, -20, 60 }));
```

```csharp
Debug.Assert(Repeat(new int[] { -1, 1, -1, 8 }).SequenceEqual(new int[] { -1 }));
```

```csharp
Debug.Assert(Repeat(new int[] { 1, 2, 3, 1, 2 }) == new int[] { 1, 2 });
```
