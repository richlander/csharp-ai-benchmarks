# mbcp-56 -- Check if a number is one less than double its reverse

## Text

Write a C# function to check if a given number is one less than twice its reverse.

## Code

```csharp
public int Rev(int num)    
{    
    int revNum = 0;    
    while (num > 0)    
    {    
        revNum = (revNum * 10 + num % 10);    
        num /= 10;    
    }    
    return revNum;    
}    

public bool Check(int n)    
{    
    return (2 * Rev(n) == n + 1);    
}
```

## Test List

```csharp
Debug.Assert(Check(70) == false);
```

```csharp
Debug.Assert(Check(23) == false);
```

```csharp
Debug.Assert(Check(73) == true);
```
