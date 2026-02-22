namespace LeetCodeConsole.Solutions.CSharp
{
public class MinStackSolution
{
    Stack<int> mainStack;
    Stack<int> minStack;

    public MinStackSolution() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        
        mainStack.Push(val);

        if (minStack.Count == 0)
        {
            minStack.Push(val);
        }
        else{
            var currentMinValue = minStack.Peek();

            minStack.Push(Math.Min(currentMinValue, val));
        }
    }
    
    public void Pop() {
        mainStack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
}