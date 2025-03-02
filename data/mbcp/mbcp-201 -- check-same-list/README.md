# mbcp-201 -- Check if all elements in a list are identical

## Text

Write a C# function to check whether the elements in a list are same or not.

## Code

```csharp
public bool ChkList(List<object> lst) 
{
    return lst.Distinct().Count() == 1;
}
```

## Test List

```csharp
Debug.Assert(ChkList(new string[] { "one", "one", "one" }) == true);
```

```csharp
Debug.Assert(!ChkList(new List<string> { "one", "Two", "Three" }));
```

```csharp
Debug.Assert(ChkList(new string[] { "bigdata", "python", "Django" }) == false);
```
