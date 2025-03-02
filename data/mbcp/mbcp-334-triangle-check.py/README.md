# mbcp334 -- Validates a triangle's existence from its sides

## Text

Write a C# function to check whether the triangle is valid or not if sides are given.

## Code

```csharp
bool CheckValidity(int a, int b, int c)  
{  
    if ((a + b <= c) || (a + c <= b) || (b + c <= a))  
    {  
        return false;  
    }  
    else  
    {  
        return true;  
    }  
}
```

## Test List

```csharp
Debug.Assert(CheckValidity(1, 2, 3) == false);
```

```csharp
Debug.Assert(CheckValidity(2, 3, 5) == false);
```

```csharp
Debug.Assert(CheckValidity(7, 10, 5) == true);
```
