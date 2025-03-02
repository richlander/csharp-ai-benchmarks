# mbcp884 -- Check if all bits are within a specified range

## Text

Write a C# function to check whether all the bits are within a given range or not.

## Code

```csharp
public bool AllBitsSetInTheGivenRange(int n, int l, int r) 
{ 
    int num = ((1 << r) - 1) ^ ((1 << (l - 1)) - 1); 
    int newNum = n & num; 
    if (num == newNum) 
    { 
        return true; 
    } 
    return false; 
}
```

## Test List

```csharp
Debug.Assert(AllBitsSetInTheGivenRange(10, 2, 1) == true);
```

```csharp
Debug.Assert(AllBitsSetInTheGivenRange(5, 2, 4) == false);
```

```csharp
Debug.Assert(AllBitsSetInTheGivenRange(22, 2, 3) == true);
```
