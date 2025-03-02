# mbcp284 -- Check if all list items match a given string

## Text

Write a function to check whether all items of a list are equal to a given string.

## Code

```csharp
public bool CheckElement(List<object> list, object element)  
{  
    bool checkElement = list.All(v => v.Equals(element));  
    return checkElement;  
}
```

## Test List

```csharp
Debug.Assert(CheckElement(new string[] { "green", "orange", "black", "white" }, 'blue') == false);
```

```csharp
Debug.Assert(CheckElement(new int[] { 1, 2, 3, 4 }, 7) == false);
```

```csharp
Debug.Assert(CheckElement(new string[] { "green", "green", "green", "green" }, 'green') == true);
```
