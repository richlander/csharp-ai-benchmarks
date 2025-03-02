# mbcp-927 -- Calculate the height of a binary tree structure

## Text

Write a function to calculate the height of the given binary tree.

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

public static int MaxHeight(Node node) 
{ 
    if (node == null) 
    { 
        return 0; 
    } 
    else 
    { 
        int leftHeight = MaxHeight(node.Left); 
        int rightHeight = MaxHeight(node.Right); 
        return (leftHeight > rightHeight) ? leftHeight + 1 : rightHeight + 1; 
    } 
}
```

## Test List

```csharp
Debug.Assert(MaxHeight(root) == 3);
```

```csharp
Debug.Assert(MaxHeight(root1) == 5);
```

```csharp
Debug.Assert(MaxHeight(root2) == 4);
```
