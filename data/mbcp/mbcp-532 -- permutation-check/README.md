# mbcp-532 -- Check if two strings are permutations of each other

## Text

Write a function to check if the two given strings are permutations of each other.

## Code

```csharp
public bool CheckPermutation(string str1, string str2) {
    int n1 = str1.Length;
    int n2 = str2.Length;
    if (n1 != n2) {
        return false;
    }
    char[] a = str1.ToCharArray();
    Array.Sort(a);
    str1 = new string(a);
    char[] b = str2.ToCharArray();
    Array.Sort(b);
    str2 = new string(b);
    for (int i = 0; i < n1; i++) {
        if (str1[i] != str2[i]) {
            return false;
        }
    }
    return true;
}
```

## Test List

```csharp
Debug.Assert(CheckPermutation("abc", "cba") == true);
```

```csharp
Debug.Assert(CheckPermutation("test", "ttew") == false);
```

```csharp
Debug.Assert(CheckPermutation("xxyz", "yxzx") == true);
```
