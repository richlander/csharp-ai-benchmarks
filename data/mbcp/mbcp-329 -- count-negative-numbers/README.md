# mbcp-329 -- Count negative numbers in a list using Python

## Text

Write a C# function to count negative numbers in a list.

## Code

```csharp
public int NegCount(List<int> list) 
{
    int negCount = 0;
    foreach (int num in list) 
    {
        if (num <= 0) 
        {
            negCount++;
        }
    }
    return negCount;
}
```

## Test List

```csharp
Debug.Assert(NegCount(new int[] { -1, -2, 3, -4, -5 }) == 4);
```

```csharp
Debug.Assert(NegCount(new int[] { 1, 2, 3 }) == 0);
```

```csharp
Debug.Assert(NegCount(new int[] { 1, 2, -3, -10, 20 }) == 2);
```
