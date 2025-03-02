# mbcp-47 -- Find last digit of factorial b divided by a

## Text

Write a C# function to find the last digit when factorial of a divides factorial of b.

## Code

```csharp
public int ComputeLastDigit(int A, int B) 
{
    int variable = 1;
    if (A == B) 
    {
        return 1;
    }
    else if ((B - A) >= 5)  
    {
        return 0;
    }
    else 
    {
        for (int i = A + 1; i <= B; i++) 
        {
            variable = (variable * (i % 10)) % 10;
        }
        return variable % 10;
    }
}
```

## Test List

```csharp
Debug.Assert(ComputeLastDigit(2, 4) == 2);
```

```csharp
Debug.Assert(ComputeLastDigit(6, 8) == 6);
```

```csharp
Debug.Assert(ComputeLastDigit(1, 2) == 2);
```
