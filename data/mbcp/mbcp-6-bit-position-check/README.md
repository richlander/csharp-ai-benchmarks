# mbcp6 -- Check if two numbers differ at only one bit

## Text

Write a C# function to check whether the two numbers differ at one bit position only or not.

## Code

```csharp
bool IsPowerOfTwo(int x) 
{ 
    return x != 0 && (x & (x - 1)) == 0; 
}

bool DifferAtOneBitPos(int a, int b) 
{ 
    return IsPowerOfTwo(a ^ b); 
}
```

## Test List

```csharp
Debug.Assert(DifferAtOneBitPos(13, 9) == true);
```

```csharp
Debug.Assert(DifferAtOneBitPos(15, 8) == false);
```

```csharp
Debug.Assert(DifferAtOneBitPos(2, 4) == false);
```
