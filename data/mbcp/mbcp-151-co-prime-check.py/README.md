# mbcp151 -- Check if a number is co-prime with another

## Text

Write a C# function to check whether the given number is co-prime or not.

## Code

```csharp
public int Gcd(int p, int q) {
    while (q != 0) {
        int temp = q;
        q = p % q;
        p = temp;
    }
    return p;
}

public bool IsCoprime(int x, int y) {
    return Gcd(x, y) == 1;
}
```

## Test List

```csharp
Debug.Assert(IsCoprime(17, 13) == true);
```

```csharp
Debug.Assert(IsCoprime(15, 21) == false);
```

```csharp
Debug.Assert(IsCoprime(25, 45) == false);
```
