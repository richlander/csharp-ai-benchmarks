# mbcp-891 -- Check if two numbers have the same digit count

## Text

Write a C# function to check whether the given two numbers have same number of digits or not.

## Code

```csharp
bool Same_Length(int A, int B) 
{ 
    while (A > 0 && B > 0) 
    { 
        A /= 10; 
        B /= 10; 
    } 
    return A == 0 && B == 0; 
}
```

## Test List

```csharp
Debug.Assert(Same_Length(12, 1) == false);
```

```csharp
Debug.Assert(Same_Length(2, 2) == true);
```

```csharp
Debug.Assert(Same_Length(10, 20) == true);
```
