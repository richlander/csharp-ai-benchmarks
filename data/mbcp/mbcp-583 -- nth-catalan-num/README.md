# mbcp-583 -- Calculate the nth Catalan number function

## Text

Write a function for nth catalan number.

## Code

```csharp
public int CatalanNumber(int num) {
    if (num <= 1) {
        return 1;
    }
    int resNum = 0;
    for (int i = 0; i < num; i++) {
        resNum += CatalanNumber(i) * CatalanNumber(num - i - 1);
    }
    return resNum;
}
```

## Test List

```csharp
Debug.Assert(CatalanNumber(10) == 16796);
```

```csharp
Debug.Assert(CatalanNumber(9) == 4862);
```

```csharp
Debug.Assert(CatalanNumber(7) == 429);
```
