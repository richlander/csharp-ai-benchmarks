# mbcp150 -- Check if a number exists in an infinite sequence

## Text

Write a C# function to find whether the given number is present in the infinite sequence or not.

## Code

```csharp
public bool DoesContainB(int a, int b, int c) 
{ 
    if (a == b) 
    { 
        return true; 
    } 
    if ((b - a) * c > 0 && (b - a) % c == 0) 
    { 
        return true; 
    } 
    return false; 
}
```

## Test List

```csharp
Debug.Assert(DoesContainB(1, 7, 3) == true);
```

```csharp
Debug.Assert(DoesContainB(1, -3, 5) == false);
```

```csharp
Debug.Assert(DoesContainB(3, 2, 5) == false);
```
