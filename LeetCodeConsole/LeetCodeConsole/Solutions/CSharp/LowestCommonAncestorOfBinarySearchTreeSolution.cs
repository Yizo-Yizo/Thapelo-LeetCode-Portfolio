public class LowestCommonAncestorOfBinarySearchTreeSolution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        if (root == null)
        {
            return null;
        }

        var current = root;

        while (current != null)
        {
            if (current.val < p.val && current.val < q.val)
            {
                current = current.right;
            }
            else if (current.val > p.val && current.val > q.val)
            {
                current = current.left;
            }
            else 
            {
                break;
            }
        }
        return current;
    }
}