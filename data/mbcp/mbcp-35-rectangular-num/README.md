# mbcp35 -- Find the n-th rectangular number efficiently

## Text

Write a function to find the n-th rectangular number.

## Code

```csharp
public int FindRectNum(int n)  
{  
    return n * (n + 1);  
}
```

## Test List

```csharp
Debug.Assert(FindRectNum(4) == 20);
```

```csharp
Debug.Assert(FindRectNum(5) == 30);
```

```csharp
Debug.Assert(FindRectNum(6) == 42);
```
