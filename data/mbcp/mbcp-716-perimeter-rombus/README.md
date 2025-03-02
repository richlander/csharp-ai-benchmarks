# mbcp716 -- Calculate the perimeter of a rhombus shape

## Text

Write a function to find the perimeter of a rombus.

## Code

```csharp
public int RombusPerimeter(int a)  
{  
    int perimeter = 4 * a;  
    return perimeter;  
}
```

## Test List

```csharp
Debug.Assert(RombusPerimeter(10) == 40);
```

```csharp
Debug.Assert(RombusPerimeter(5) == 20);
```

```csharp
Debug.Assert(RombusPerimeter(4) == 16);
```
