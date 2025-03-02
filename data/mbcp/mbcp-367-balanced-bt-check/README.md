# mbcp367 -- Check if a binary tree is balanced

## Text

Write a function to check if a binary tree is balanced or not.

## Code

```csharp
class Node 
{ 
    public int Data; 
    public Node Left; 
    public Node Right; 

    public Node(int data) 
    { 
        Data = data; 
        Left = null; 
        Right = null; 
    } 
}

public int GetHeight(Node root) 
{ 
    if (root == null) 
    { 
        return 0; 
    } 
    return Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1; 
}

public bool IsTreeBalanced(Node root) 
{ 
    if (root == null) 
    { 
        return true; 
    } 
    int lh = GetHeight(root.Left); 
    int rh = GetHeight(root.Right); 
    if (Math.Abs(lh - rh) <= 1 && IsTreeBalanced(root.Left) && IsTreeBalanced(root.Right)) 
    { 
        return true; 
    } 
    return false; 
}
```

## Test List

```csharp
Debug.Assert(IsTreeBalanced(root) == false);
```

```csharp
Debug.Assert(IsTreeBalanced(root1) == true);
```

```csharp
Debug.Assert(IsTreeBalanced(root2) == false);
```
