public class MaximumDepthofBinaryTreeSolution
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return 1 + Math.Max(leftDepth, rightDepth);
    }
}
