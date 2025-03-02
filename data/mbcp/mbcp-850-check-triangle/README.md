# mbcp850 -- Check if positive area triangle angles are valid

## Text

Write a function to check if a triangle of positive area is possible with the given angles.

## Code

```csharp
bool IsTriangleExists(int a, int b, int c) 
{ 
    if (a != 0 && b != 0 && c != 0 && (a + b + c) == 180) 
    { 
        if ((a + b) >= c || (b + c) >= a || (a + c) >= b) 
        { 
            return true; 
        } 
        else 
        { 
            return false; 
        } 
    } 
    else 
    { 
        return false; 
    } 
}
```

## Test List

```csharp
Debug.Assert(IsTriangleExists(50, 60, 70) == true);
```

```csharp
Debug.Assert(IsTriangleExists(90, 45, 45) == true);
```

```csharp
Debug.Assert(IsTriangleExists(150, 30, 70) == false);
```
