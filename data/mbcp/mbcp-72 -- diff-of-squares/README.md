# mbcp-72 -- Check if a number is a difference of two squares

## Text

Write a C# function to check whether the given number can be represented as difference of two squares or not.

## Code

```csharp
bool DifSquare(int n) 
{ 
    if (n % 4 != 2) 
    { 
        return true; 
    } 
    return false; 
}
```

## Test List

```csharp
Debug.Assert(DifSquare(5) == true);
```

```csharp
Debug.Assert(DifSquare(10) == false);
```

```csharp
Debug.Assert(DifSquare(15) == true);
```
