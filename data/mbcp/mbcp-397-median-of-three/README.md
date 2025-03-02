# mbcp397 -- Find the median of three given numbers

## Text

Write a function to find the median of three specific numbers.

## Code

```csharp
public static int MedianNumbers(int a, int b, int c) {
    int median;
    if (a > b) {
        if (a < c) {
            median = a;
        } else if (b > c) {
            median = b;
        } else {
            median = c;
        }
    } else {
        if (a > c) {
            median = a;
        } else if (b < c) {
            median = b;
        } else {
            median = c;
        }
    }
    return median;
}
```

## Test List

```csharp
Debug.Assert(MedianNumbers(25, 55, 65) == 55.0);
```

```csharp
Debug.Assert(MedianNumbers(20, 10, 30) == 20.0);
```

```csharp
Debug.Assert(MedianNumbers(15, 45, 75) == 45.0);
```
