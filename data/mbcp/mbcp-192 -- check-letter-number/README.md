# mbcp-192 -- Check if a string contains letters and numbers

## Text

Write a C# function to check whether a string has atleast one letter and one number.

## Code

```csharp
public bool CheckString(string str) 
{
    bool flagL = false;
    bool flagN = false;
    foreach (char i in str) 
    {
        if (char.IsLetter(i)) 
        {
            flagL = true;  
        }
        if (char.IsDigit(i)) 
        {
            flagN = true;
        }
    }
    return flagL && flagN;
}
```

## Test List

```csharp
Debug.Assert(CheckString("thishasboth29") == true);
```

```csharp
Debug.Assert(CheckString("python") == false);
```

```csharp
Debug.Assert(CheckString("string") == false);
```
