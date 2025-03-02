# mbcp256 -- Count primes below a given non-negative number

## Text

Write a C# function to count the number of prime numbers less than a given non-negative number.

## Code

```csharp
public int CountPrimesNums(int n) {
    int ctr = 0;
    for (int num = 0; num < n; num++) {
        if (num <= 1) {
            continue;
        }
        bool isPrime = true;
        for (int i = 2; i < num; i++) {
            if (num % i == 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            ctr++;
        }
    }
    return ctr;
}
```

## Test List

```csharp
Debug.Assert(CountPrimesNums(5) == 2);
```

```csharp
Debug.Assert(CountPrimesNums(10) == 4);
```

```csharp
Debug.Assert(CountPrimesNums(100) == 25);
```
