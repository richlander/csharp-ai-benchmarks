# mbcp-356 -- Find the third angle of a triangle from two angles

## Text

Write a function to find the third angle of a triangle using two angles.

## Code

```csharp
public int FindAngle(int a, int b)  
{  
    int c = 180 - (a + b);  
    return c;  
}
```

## Test List

```csharp
Debug.Assert(FindAngle(47, 89) == 44);
```

```csharp
Debug.Assert(FindAngle(45, 95) == 40);
```

```csharp
Debug.Assert(FindAngle(50, 40) == 90);
```
