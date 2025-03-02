# mbcp-283 -- Check if digit frequencies do not exceed their values

## Text

Write a C# function to check whether the frequency of each digit is less than or equal to the digit itself.

## Code

```csharp
public bool Validate(int n) 
{ 
    for (int i = 0; i < 10; i++) 
    { 
        int temp = n; 
        int count = 0; 
        while (temp > 0) 
        { 
            if (temp % 10 == i) 
            { 
                count++; 
            } 
            if (count > i) 
            { 
                return false; 
            } 
            temp /= 10; 
        } 
    } 
    return true; 
}
```

## Test List

```csharp
Debug.Assert(Validate(1234) == true);
```

```csharp
Debug.Assert(Validate(51241) == false);
```

```csharp
Debug.Assert(Validate(321) == true);
```
