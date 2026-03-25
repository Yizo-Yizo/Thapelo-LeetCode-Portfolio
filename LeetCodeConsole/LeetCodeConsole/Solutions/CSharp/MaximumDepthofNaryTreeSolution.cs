public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
public class MaximumDepthofNaryTreeSolution
{
    public int MaxDepth(Node root) {

        int currentMaxDepth = 0;
        int childMaxDepth = 0;

        if (root == null)
        {
            return 0;
        }

        foreach (var child in root.children)
        {

            childMaxDepth = MaxDepth(child);
            currentMaxDepth = Math.Max(currentMaxDepth, childMaxDepth);
        }

        return 1 + Math.Max(childMaxDepth, currentMaxDepth);
    }
}