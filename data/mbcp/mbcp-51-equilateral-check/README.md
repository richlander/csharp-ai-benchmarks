# mbcp51 -- Check if a triangle is equilateral or not

## Text

Write a function to print check if the triangle is equilateral or not.

## Code

```csharp
public bool CheckEquilateral(int x, int y, int z)  
{  
    if (x == y && y == z)  
        return true;  
    else  
        return false;  
}
```

## Test List

```csharp
Debug.Assert(CheckEquilateral(6, 8, 12) == false);
```

```csharp
Debug.Assert(CheckEquilateral(6, 6, 12) == false);
```

```csharp
Debug.Assert(CheckEquilateral(6, 6, 6) == true);
```
