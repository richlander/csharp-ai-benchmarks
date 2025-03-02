# mbcp-501 -- Find common divisor of two numbers in a pair

## Text

Write a C# function to find common divisor between two numbers in a given pair.

## Code

```csharp
int Ngcd(int x, int y) {
    int i = 1;
    int gcd = 1;
    while (i <= x && i <= y) {
        if (x % i == 0 && y % i == 0) {
            gcd = i;
        }
        i++;
    }
    return gcd;
}

int NumCommDiv(int x, int y) {
    int n = Ngcd(x, y);
    int result = 0;
    int z = (int)Math.Sqrt(n);
    int i = 1;
    while (i <= z) {
        if (n % i == 0) {
            result += 2;
            if (i == n / i) {
                result--;
            }
        }
        i++;
    }
    return result;
}
```

## Test List

```csharp
Debug.Assert(NumCommDiv(2, 4) == 2);
```

```csharp
Debug.Assert(NumCommDiv(2, 8) == 2);
```

```csharp
Debug.Assert(NumCommDiv(12, 24) == 6);
```
