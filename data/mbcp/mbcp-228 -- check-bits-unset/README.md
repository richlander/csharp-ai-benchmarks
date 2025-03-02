# mbcp-228 -- Check if all bits are unset in the given range

## Text

Write a C# function to check whether all the bits are unset in the given range or not.

## Code

```csharp
public static bool AllBitsSetInTheGivenRange(int n, int l, int r)  
{  
    int num = (((1 << r) - 1) ^ ((1 << (l - 1)) - 1));  
    int newNum = n & num;  
    return newNum == 0;  
}
```

## Test List

```csharp
Debug.Assert(AllBitsSetInTheGivenRange(4, 1, 2) == true);
```

```csharp
Debug.Assert(AllBitsSetInTheGivenRange(17, 2, 4) == true);
```

```csharp
Debug.Assert(AllBitsSetInTheGivenRange(39, 4, 6) == false);
```
