# mbcp-904 -- Determine if a number is even or odd

## Text

Write a function to return true if the given number is even else return false.

## Code

```csharp
public bool EvenNum(int x)  
{  
    if (x % 2 == 0)  
    {  
        return true;  
    }  
    else  
    {  
        return false;  
    }  
}
```

## Test List

```csharp
Debug.Assert(EvenNum(13.5) == false);
```

```csharp
Debug.Assert(EvenNum(0) == true);
```

```csharp
Debug.Assert(EvenNum(-9) == false);
```
