# mbcp804 -- Check if the product of numbers is even

## Text

Write a C# function to check whether the product of numbers is even or not.

## Code

```csharp
bool IsProductEven(int[] arr, int n) 
{ 
    for (int i = 0; i < n; i++) 
    { 
        if ((arr[i] & 1) == 0) 
        { 
            return true; 
        } 
    } 
    return false; 
}
```

## Test List

```csharp
Debug.Assert(IsProductEven(new int[] { 1, 2, 3 }, 3) == true);
```

```csharp
Debug.Assert(IsProductEven(new int[] { 1, 2, 1, 4 }, 4) == true);
```

```csharp
Debug.Assert(IsProductEven(new int[] { 1, 1 }, 2) == false);
```
