# mbcp-600 -- Check if a number is even using bitwise operator

## Text

Write a C# function to check whether the given number is even or not using bitwise operator.

## Code

```csharp
bool IsEven(int n) 
{ 
    if ((n ^ 1) == (n + 1)) 
    { 
        return true; 
    } 
    else 
    { 
        return false; 
    } 
}
```

## Test List

```csharp
Debug.Assert(IsEven(1) == false);
```

```csharp
Debug.Assert(IsEven(2) == true);
```

```csharp
Debug.Assert(IsEven(3) == false);
```
