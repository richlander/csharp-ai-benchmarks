# mbcp-619 -- Move all numbers to the specified string in function

## Text

Write a function to move all the numbers in it to the given string.

## Code

```csharp
public string MoveNum(string testStr) 
{
    string res = string.Empty;
    string dig = string.Empty;
    foreach (char ele in testStr) 
    {
        if (char.IsDigit(ele)) 
        {
            dig += ele;
        } 
        else 
        {
            res += ele;
        }
    }
    res += dig;
    return res;
}
```

## Test List

```csharp
Debug.Assert(MoveNum("I1love143you55three3000thousand") == "Iloveyouthreethousand1143553000");
```

```csharp
Debug.Assert(MoveNum("Avengers124Assemble") == "AvengersAssemble124");
```

```csharp
Debug.Assert(MoveNum("Its11our12path13to14see15things16do17things") == "Itsourpathtoseethingsdothings11121314151617");
```
