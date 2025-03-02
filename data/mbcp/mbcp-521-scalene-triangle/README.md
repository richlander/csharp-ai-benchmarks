# mbcp521 -- Check if a triangle is scalene using a function

## Text

Write a function to print check if the triangle is scalene or not.

## Code

```csharp
public bool CheckIsosceles(int x, int y, int z)  
{  
    if (x != y && y != z && z != x)  
        return true;  
    else  
        return false;  
}
```

## Test List

```csharp
Debug.Assert(CheckIsosceles(6, 8, 12) == true);
```

```csharp
Debug.Assert(CheckIsosceles(6, 6, 12) == false);
```

```csharp
Debug.Assert(CheckIsosceles(6, 15, 20) == true);
```
