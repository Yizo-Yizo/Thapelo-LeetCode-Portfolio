public class BinaryTreeLevelOrderTraversalSolution
{
    public IList<IList<int>> LevelOrder(TreeNode root) {
        
        var output = new List<IList<int>>();

        if (root == null)
        {
            return output;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            var levelSize = queue.Count;
            var currentLevelNodes = new List<int>();

            for (int i = 0; i < levelSize; i++)
            {
                var currentNode = queue.Dequeue();
                currentLevelNodes.Add(currentNode.val);

                if (currentNode.left != null) queue.Enqueue(currentNode.left);
                if (currentNode.right != null) queue.Enqueue(currentNode.right);
            }

            output.Add(currentLevelNodes);
        }

        return output;
    }
}