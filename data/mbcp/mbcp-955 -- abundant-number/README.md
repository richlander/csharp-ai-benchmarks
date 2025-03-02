# mbcp-955 -- Determine if a number is abundant or not

## Text

Write a function to find out, if the given number is abundant.

## Code

```csharp
public bool IsAbundant(int n) {
    int fctrsum = 0;
    for (int fctr = 1; fctr < n; fctr++) {
        if (n % fctr == 0) {
            fctrsum += fctr;
        }
    }
    return fctrsum > n;
}
```

## Test List

```csharp
Debug.Assert(IsAbundant(12) == true);
```

```csharp
Debug.Assert(IsAbundant(13) == false);
```

```csharp
Debug.Assert(IsAbundant(9) == false);
```
