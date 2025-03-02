# mbcp188 -- Check if a number can be expressed as two squares

## Text

Write a C# function to check whether the given number can be represented by product of two squares or not.

## Code

```csharp
bool ProdSquare(int n)  
{  
    for (int i = 2; i <= n; i++)  
    {  
        if (i * i < n + 1)  
        {  
            for (int j = 2; j <= n; j++)  
            {  
                if (i * i * j * j == n)  
                {  
                    return true;  
                }  
            }  
        }  
    }  
    return false;  
}
```

## Test List

```csharp
Debug.Assert(ProdSquare(25) == false);
```

```csharp
Debug.Assert(ProdSquare(30) == false);
```

```csharp
Debug.Assert(ProdSquare(16) == true);
```
