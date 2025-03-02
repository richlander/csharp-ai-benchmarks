# mbcp-973 -- Left rotate a string using a Python function

## Text

Write a C# function to left rotate the string.

## Code

```csharp
string LeftRotate(string s, int d) {
    string tmp = s.Substring(d) + s.Substring(0, d);
    return tmp;
}
```

## Test List

```csharp
Debug.Assert(LeftRotate("python", 2) == "thonpy");
```

```csharp
Debug.Assert(LeftRotate("bigdata", 3) == "databig");
```

```csharp
Debug.Assert(LeftRotate("hadoop", 1) == "adooph");
```
