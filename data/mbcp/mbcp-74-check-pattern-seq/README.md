# mbcp74 -- Check if input follows the given patterns sequence

## Text

Write a function to check whether it follows the sequence given in the patterns array.

## Code

```csharp
public bool IsSamePatterns(string[] colors, string[] patterns)    
{    
    if (colors.Length != patterns.Length) 
    {
        return false;    
    }    

    Dictionary<string, List<string>> sdict = new Dictionary<string, List<string>>();
    HashSet<string> pset = new HashSet<string>();
    HashSet<string> sset = new HashSet<string>();    

    for (int i = 0; i < patterns.Length; i++) 
    {
        pset.Add(patterns[i]);
        sset.Add(colors[i]);
        
        if (!sdict.ContainsKey(patterns[i])) 
        {
            sdict[patterns[i]] = new List<string>();
        }

        sdict[patterns[i]].Add(colors[i]);
    }

    if (pset.Count != sset.Count) 
    {
        return false;   
    }   

    foreach (var values in sdict.Values) 
    {
        for (int i = 0; i < values.Count - 1; i++) 
        {
            if (values[i] != values[i + 1]) 
            {
                return false;
            }
        }
    }

    return true; 
}
```

## Test List

```csharp
Debug.Assert(IsSamePatterns(new string[] { "red", "green", "green" }, new string[] { "a", "b", "b" }) == true);
```

```csharp
Debug.Assert(IsSamePatterns(new string[] { "red", "green", "greenn" }, new string[] { "a", "b", "b" }) == false);
```

```csharp
Debug.Assert(IsSamePatterns(new string[] { "red", "green", "greenn" }, new string[] { "a", "b"}) == false);
```
