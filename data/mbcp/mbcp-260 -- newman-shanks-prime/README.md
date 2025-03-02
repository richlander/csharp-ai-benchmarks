# mbcp-260 -- Find the nth Newman-Shanks-Williams prime

## Text

Write a function to find the nth newman–shanks–williams prime number.

## Code

```csharp
public int NewmanPrime(int n) 
{ 
    if (n == 0 || n == 1) 
        return 1; 
    return 2 * NewmanPrime(n - 1) + NewmanPrime(n - 2); 
}
```

## Test List

```csharp
Debug.Assert(NewmanPrime(3) == 7);
```

```csharp
Debug.Assert(NewmanPrime(4) == 17);
```

```csharp
Debug.Assert(NewmanPrime(5) == 41);
```
