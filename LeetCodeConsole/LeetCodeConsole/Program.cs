using System;
using LeetCodeConsole.Solutions.CSharp;
using LeetCodeConsole.Solutions.SQL;

namespace LeetCodeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║   LeetCode Solutions Runner - Thapelo S.   ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Select a category:");
                Console.WriteLine();
                Console.WriteLine("  [1] C# / Algorithm Problems");
                Console.WriteLine("  [2] SQL Problems");
                Console.WriteLine();
                Console.WriteLine("  [0] Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowCSharpProblems();
                        break;
                    case "2":
                        ShowSQLProblems();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("\nGoodbye!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ShowCSharpProblems()
        {
            bool inCSharpMenu = true;

            while (inCSharpMenu)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║         C# / Algorithm Problems            ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Select a problem to run:");
                Console.WriteLine();
                Console.WriteLine("  [1] Two Sum");
                Console.WriteLine("  [2] Valid Anagram");
                Console.WriteLine("  [3] Evaluate Reverse Polish Notation");
                Console.WriteLine("  [4] Best Time to Buy and Sell Stock");
                Console.WriteLine("  [5] Move Zeroes");
                Console.WriteLine("  [6] Two Sum II - Input Array Is Sorted");
                Console.WriteLine("  [7] Intersection of Two Arrays");
                Console.WriteLine("  [8] Reverse Linked List");
                Console.WriteLine("  [9] Valid Parentheses");
                Console.WriteLine("  [10] Implement Queue Using Stacks");
                Console.WriteLine("  [11] Min Stack");
                Console.WriteLine("  [12] Maximum Depth of Binary Tree");
                Console.WriteLine("  [13] Fibonacci Number");
                Console.WriteLine("  [14] Merge Sorted Array");
                Console.WriteLine("  [15] Search Insert Position");
                Console.WriteLine("  [16] Climbing Stairs");
                Console.WriteLine("  [17] Maximum Depth of N-ary Tree");
                Console.WriteLine("  [18] Binary Tree Level Order Traversal");
                Console.WriteLine("  [19] Kth Largest Element in an Array");
                Console.WriteLine("  [20] Majority Element");
                Console.WriteLine("  [21] Product of Array Except Self");
                Console.WriteLine("  [22] Add Two Numbers");
                Console.WriteLine("  [23] Lowest Common Ancestor of a Binary Search Tree");
                Console.WriteLine("  [24] Number of Islands");
                Console.WriteLine("  [25] House Robber");
                Console.WriteLine();
                Console.WriteLine("  [0] Back to Main Menu");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunTwoSum();
                        break;
                    case "2":
                        RunIsAnagram();
                        break;
                    case "3":
                        RunEvalRPN();
                        break;
                    case "4":
                        RunMaxProfit();
                        break;
                    case "5":
                        RunMoveZeroes();
                        break;
                    case "6":
                        RunTwoSumInputArrayIsSorted();
                        break;
                    case "7":
                        RunIntersectionOfTwoArrays();
                        break;
                    case "8":
                        RunReverseLinkedList();
                        break;
                    case "9":
                        RunValidParentheses();
                        break;
                    case "10":
                        RunImplementQueueUsingStacks();
                        break;
                    case "11":
                        RunMinStack();
                        break;
                    case "12":
                        RunMaximumDepthOfBinaryTree();
                        break;
                    case "13":
                        RunFibonacciNumber();
                        break;
                    case "14":
                        RunMergeSortedArray();
                        break;
                    case "15":
                        RunSearchInsertPosition();
                        break;
                    case "16":
                        RunClimbingStairs();
                        break;
                    case "17":
                        RunMaximumDepthOfNaryTree();
                        break;
                    case "18":
                        RunBinaryTreeLevelOrderTraversal();
                        break;
                    case "19":
                        RunKthLargestElement();
                        break;
                    case "20":
                        RunMajorityElement();
                        break;
                    case "21":
                        RunProductOfArrayExceptSelf();
                        break;
                    case "22":
                        RunAddTwoNumbers();
                        break;
                    case "23":
                        RunLowestCommonAncestorBST();
                        break;
                    case "24":
                        RunNumberOfIslands();
                        break;
                    case "25":
                        RunHouseRobber();
                        break;
                    case "0":
                        inCSharpMenu = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ShowSQLProblems()
        {
            bool inSQLMenu = true;

            while (inSQLMenu)
            {
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║              SQL Problems                  ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Select a problem to view:");
                Console.WriteLine();
                Console.WriteLine("  [1] Recyclable and Low Fat Products");
                Console.WriteLine("  [2] Customers Who Visited but Did Not Make Transactions");
                Console.WriteLine("  [3] Employee Bonus");
                Console.WriteLine("  [4] Not Boring Movies");
                Console.WriteLine("  [5] Average Selling Price");
                Console.WriteLine("  [6] Rank Scores");
                Console.WriteLine("  [7] Nth Highest Salary");
                Console.WriteLine("  [8] Department Top Three Salaries");
                Console.WriteLine("  [9] Consecutive Numbers");
                Console.WriteLine("  [10] Trips and Users");
                Console.WriteLine();
                Console.WriteLine("  [0] Back to Main Menu");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RecyclableAndLowFatProducts.DisplayProblem();
                        break;
                    case "2":
                        CustomerWhoVisitedbutDidNotMakeAnyTransactions.DisplayProblem();
                        break;
                    case "3":
                        EmployeeBonus.DisplayProblem();
                        break;
                    case "4":
                        NotBoringMovies.DisplayProblem();
                        break;
                    case "5":
                        AverageSellingPrice.DisplayProblem();
                        break;
                    case "6":
                        RankScores.DisplayProblem();
                        break;
                    case "7":
                        NthHighestSalary.DisplayProblem();
                        break;
                    case "8":
                        DepartmentTopThreeSalaries.DisplayProblem();
                        break;
                    case "9":
                        ConsecutiveNumbers.DisplayProblem();
                        break;
                    case "10":
                        TripAndUsers.DisplayProblem();
                        break;
                    case "0":
                        inSQLMenu = false;
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // C# Problem Solutions

        static void RunTwoSum()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Two Sum");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new TwoSumSolution();

            // Test case 1
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] result1 = solution.TwoSum(nums1, target1);
            Console.WriteLine($"Test 1: nums = [{string.Join(", ", nums1)}], target = {target1}");
            Console.WriteLine($"Output: [{result1[0]}, {result1[1]}]");
            Console.WriteLine($"Expected: [0, 1]\n");

            // Test case 2
            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;
            int[] result2 = solution.TwoSum(nums2, target2);
            Console.WriteLine($"Test 2: nums = [{string.Join(", ", nums2)}], target = {target2}");
            Console.WriteLine($"Output: [{result2[0]}, {result2[1]}]");
            Console.WriteLine($"Expected: [1, 2]\n");

            // Test case 3
            int[] nums3 = { 3, 3 };
            int target3 = 6;
            int[] result3 = solution.TwoSum(nums3, target3);
            Console.WriteLine($"Test 3: nums = [{string.Join(", ", nums3)}], target = {target3}");
            Console.WriteLine($"Output: [{result3[0]}, {result3[1]}]");
            Console.WriteLine($"Expected: [0, 1]\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunIsAnagram()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Valid Anagram");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new IsAnagramSolution();

            // Test case 1
            string s1 = "anagram";
            string t1 = "nagaram";
            bool result1 = solution.IsAnagram(s1, t1);
            Console.WriteLine($"Test 1: s = \"{s1}\", t = \"{t1}\"");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine($"Expected: True\n");

            // Test case 2
            string s2 = "rat";
            string t2 = "car";
            bool result2 = solution.IsAnagram(s2, t2);
            Console.WriteLine($"Test 2: s = \"{s2}\", t = \"{t2}\"");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine($"Expected: False\n");

            // Test case 3
            string s3 = "listen";
            string t3 = "silent";
            bool result3 = solution.IsAnagram(s3, t3);
            Console.WriteLine($"Test 3: s = \"{s3}\", t = \"{t3}\"");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine($"Expected: True\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunEvalRPN()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Evaluate Reverse Polish Notation");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new EvaluateReversePolishNotationSolution();

            // Test case 1
            string[] tokens1 = { "2", "1", "+", "3", "*" };
            int result1 = solution.EvalRPN(tokens1);
            Console.WriteLine($"Test 1: tokens = [\"{string.Join("\", \"", tokens1)}\"]");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine($"Expected: 9");
            Console.WriteLine($"Explanation: ((2 + 1) * 3) = 9\n");

            // Test case 2
            string[] tokens2 = { "4", "13", "5", "/", "+" };
            int result2 = solution.EvalRPN(tokens2);
            Console.WriteLine($"Test 2: tokens = [\"{string.Join("\", \"", tokens2)}\"]");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine($"Expected: 6");
            Console.WriteLine($"Explanation: (4 + (13 / 5)) = 6\n");

            // Test case 3
            string[] tokens3 = { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };
            int result3 = solution.EvalRPN(tokens3);
            Console.WriteLine($"Test 3: tokens = [\"{string.Join("\", \"", tokens3)}\"]");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine($"Expected: 22\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunMaxProfit()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Best Time to Buy and Sell Stock");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new BestTimeToBuyAndSellStockSolution();

            // Test case 1
            int[] prices1 = { 7, 1, 5, 3, 6, 4 };
            int result1 = solution.MaxProfit(prices1);
            Console.WriteLine($"Test 1: prices = [{string.Join(", ", prices1)}]");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine($"Expected: 5");
            Console.WriteLine($"Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5\n");

            // Test case 2
            int[] prices2 = { 7, 6, 4, 3, 1 };
            int result2 = solution.MaxProfit(prices2);
            Console.WriteLine($"Test 2: prices = [{string.Join(", ", prices2)}]");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine($"Expected: 0");
            Console.WriteLine($"Explanation: No profit can be made, so the maximum profit is 0\n");

            // Test case 3
            int[] prices3 = { 2, 4, 1, 7, 5, 11 };
            int result3 = solution.MaxProfit(prices3);
            Console.WriteLine($"Test 3: prices = [{string.Join(", ", prices3)}]");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine($"Expected: 10");
            Console.WriteLine($"Explanation: Buy on day 3 (price = 1) and sell on day 6 (price = 11), profit = 11-1 = 10\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunMoveZeroes()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Move Zeroes");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new MoveZeroesSolution();

            // Test case 1
            int[] nums1 = { 0, 1, 0, 3, 12 };
            solution.MoveZeroes(nums1);
            Console.WriteLine($"Test 1: nums = [0, 1, 0, 3, 12]");
            Console.WriteLine($"Output: [{string.Join(", ", nums1)}]");
            Console.WriteLine($"Expected: [1, 3, 12, 0, 0]\n");

            // Test case 2
            int[] nums2 = { 0 };
            solution.MoveZeroes(nums2);
            Console.WriteLine($"Test 2: nums = [0]");
            Console.WriteLine($"Output: [{string.Join(", ", nums2)}]");
            Console.WriteLine($"Expected: [0]\n");

            // Test case 3
            int[] nums3 = { 1, 2, 3, 4, 5 };
            solution.MoveZeroes(nums3);
            Console.WriteLine($"Test 3: nums = [1, 2, 3, 4, 5]");
            Console.WriteLine($"Output: [{string.Join(", ", nums3)}]");
            Console.WriteLine($"Expected: [1, 2, 3, 4, 5]\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunTwoSumInputArrayIsSorted()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Two Sum II - Input Array Is Sorted");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new TwoSumInputArrayIsSortedSolution();

            // Test case 1
            int[] numbers1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] result1 = solution.TwoSum(numbers1, target1);
            Console.WriteLine($"Test 1: numbers = [{string.Join(", ", numbers1)}], target = {target1}");
            Console.WriteLine($"Output: [{result1[0]}, {result1[1]}]");
            Console.WriteLine($"Expected: [1, 2]");
            Console.WriteLine($"Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2 (1-indexed)\n");

            // Test case 2
            int[] numbers2 = { 2, 3, 4 };
            int target2 = 6;
            int[] result2 = solution.TwoSum(numbers2, target2);
            Console.WriteLine($"Test 2: numbers = [{string.Join(", ", numbers2)}], target = {target2}");
            Console.WriteLine($"Output: [{result2[0]}, {result2[1]}]");
            Console.WriteLine($"Expected: [1, 3]");
            Console.WriteLine($"Explanation: The sum of 2 and 4 is 6. Therefore, index1 = 1, index2 = 3 (1-indexed)\n");

            // Test case 3
            int[] numbers3 = { -1, 0 };
            int target3 = -1;
            int[] result3 = solution.TwoSum(numbers3, target3);
            Console.WriteLine($"Test 3: numbers = [{string.Join(", ", numbers3)}], target = {target3}");
            Console.WriteLine($"Output: [{result3[0]}, {result3[1]}]");
            Console.WriteLine($"Expected: [1, 2]");
            Console.WriteLine($"Explanation: The sum of -1 and 0 is -1. Therefore, index1 = 1, index2 = 2 (1-indexed)\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunIntersectionOfTwoArrays()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Intersection of Two Arrays");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new IntersectionOfTwoArraysSolution();

            // Test case 1
            int[] nums1_1 = { 1, 2, 2, 1 };
            int[] nums2_1 = { 2, 2 };
            int[] result1 = solution.Intersection(nums1_1, nums2_1);
            Console.WriteLine($"Test 1: nums1 = [{string.Join(", ", nums1_1)}], nums2 = [{string.Join(", ", nums2_1)}]");
            Console.WriteLine($"Output: [{string.Join(", ", result1)}]");
            Console.WriteLine($"Expected: [2]\n");

            // Test case 2
            int[] nums1_2 = { 4, 9, 5 };
            int[] nums2_2 = { 9, 4, 9, 8, 4 };
            int[] result2 = solution.Intersection(nums1_2, nums2_2);
            Console.WriteLine($"Test 2: nums1 = [{string.Join(", ", nums1_2)}], nums2 = [{string.Join(", ", nums2_2)}]");
            Console.WriteLine($"Output: [{string.Join(", ", result2)}]");
            Console.WriteLine($"Expected: [9, 4] or [4, 9]\n");

            // Test case 3
            int[] nums1_3 = { 1, 2, 3 };
            int[] nums2_3 = { 4, 5, 6 };
            int[] result3 = solution.Intersection(nums1_3, nums2_3);
            Console.WriteLine($"Test 3: nums1 = [{string.Join(", ", nums1_3)}], nums2 = [{string.Join(", ", nums2_3)}]");
            Console.WriteLine($"Output: [{string.Join(", ", result3)}]");
            Console.WriteLine($"Expected: []\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunReverseLinkedList()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Reverse Linked List");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new ReverseLinkedListSolution();

            // Test case 1: [1,2,3,4,5]
            var head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            Console.WriteLine("Test 1: head = [1, 2, 3, 4, 5]");
            var result1 = solution.ReverseList(head1);
            Console.Write("Output: [");
            PrintList(result1);
            Console.WriteLine("]");
            Console.WriteLine("Expected: [5, 4, 3, 2, 1]\n");

            // Test case 2: [1,2]
            var head2 = new ListNode(1, new ListNode(2));
            Console.WriteLine("Test 2: head = [1, 2]");
            var result2 = solution.ReverseList(head2);
            Console.Write("Output: [");
            PrintList(result2);
            Console.WriteLine("]");
            Console.WriteLine("Expected: [2, 1]\n");

            // Test case 3: []
            ListNode head3 = null;
            Console.WriteLine("Test 3: head = []");
            var result3 = solution.ReverseList(head3);
            Console.Write("Output: [");
            PrintList(result3);
            Console.WriteLine("]");
            Console.WriteLine("Expected: []\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void PrintList(ListNode head)
        {
            var current = head;
            bool first = true;
            while (current != null)
            {
                if (!first) Console.Write(", ");
                Console.Write(current.val);
                first = false;
                current = current.next;
            }
        }

        static void RunValidParentheses()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Valid Parentheses");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new ValidParentheseSolution();

            // Test case 1
            string s1 = "()";
            bool result1 = solution.IsValid(s1);
            Console.WriteLine($"Test 1: s = \"{s1}\"");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine($"Expected: True\n");

            // Test case 2
            string s2 = "()[]{}";
            bool result2 = solution.IsValid(s2);
            Console.WriteLine($"Test 2: s = \"{s2}\"");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine($"Expected: True\n");

            // Test case 3
            string s3 = "(]";
            bool result3 = solution.IsValid(s3);
            Console.WriteLine($"Test 3: s = \"{s3}\"");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine($"Expected: False\n");

            // Test case 4
            string s4 = "([])";
            bool result4 = solution.IsValid(s4);
            Console.WriteLine($"Test 4: s = \"{s4}\"");
            Console.WriteLine($"Output: {result4}");
            Console.WriteLine($"Expected: True\n");

            // Test case 5
            string s5 = "([)]";
            bool result5 = solution.IsValid(s5);
            Console.WriteLine($"Test 5: s = \"{s5}\"");
            Console.WriteLine($"Output: {result5}");
            Console.WriteLine($"Expected: False\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunImplementQueueUsingStacks()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Implement Queue Using Stacks");
            Console.WriteLine("═══════════════════════════════════════\n");

            var queue = new ImplementQueueUsingStacksSolution();

            Console.WriteLine("Operations:");
            Console.WriteLine("  queue.Push(1)");
            queue.Push(1);
            Console.WriteLine("  queue.Push(2)");
            queue.Push(2);

            int peekResult = queue.Peek();
            Console.WriteLine($"  queue.Peek() -> {peekResult}");
            Console.WriteLine($"  Expected: 1\n");

            int popResult = queue.Pop();
            Console.WriteLine($"  queue.Pop() -> {popResult}");
            Console.WriteLine($"  Expected: 1\n");

            bool emptyResult = queue.Empty();
            Console.WriteLine($"  queue.Empty() -> {emptyResult}");
            Console.WriteLine($"  Expected: False\n");

            // Additional test
            Console.WriteLine("Additional test:");
            var queue2 = new ImplementQueueUsingStacksSolution();
            queue2.Push(10);
            queue2.Push(20);
            queue2.Push(30);
            Console.WriteLine("  Push: 10, 20, 30");
            Console.WriteLine($"  Pop: {queue2.Pop()} (Expected: 10)");
            Console.WriteLine($"  Pop: {queue2.Pop()} (Expected: 20)");
            Console.WriteLine($"  Peek: {queue2.Peek()} (Expected: 30)");
            Console.WriteLine($"  Empty: {queue2.Empty()} (Expected: False)");
            Console.WriteLine($"  Pop: {queue2.Pop()} (Expected: 30)");
            Console.WriteLine($"  Empty: {queue2.Empty()} (Expected: True)");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunMinStack()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Min Stack");
            Console.WriteLine("═══════════════════════════════════════\n");

            var minStack = new MinStackSolution();

            Console.WriteLine("Operations:");
            Console.WriteLine("  minStack.Push(-2)");
            minStack.Push(-2);
            Console.WriteLine("  minStack.Push(0)");
            minStack.Push(0);
            Console.WriteLine("  minStack.Push(-3)");
            minStack.Push(-3);

            Console.WriteLine($"  minStack.GetMin() -> {minStack.GetMin()}");
            Console.WriteLine($"  Expected: -3\n");

            Console.WriteLine("  minStack.Pop()");
            minStack.Pop();

            Console.WriteLine($"  minStack.Top() -> {minStack.Top()}");
            Console.WriteLine($"  Expected: 0\n");

            Console.WriteLine($"  minStack.GetMin() -> {minStack.GetMin()}");
            Console.WriteLine($"  Expected: -2\n");

            // Additional test
            Console.WriteLine("Additional test:");
            var minStack2 = new MinStackSolution();
            minStack2.Push(5);
            minStack2.Push(3);
            minStack2.Push(7);
            minStack2.Push(1);
            Console.WriteLine("  Push: 5, 3, 7, 1");
            Console.WriteLine($"  GetMin: {minStack2.GetMin()} (Expected: 1)");
            minStack2.Pop();
            Console.WriteLine("  Pop");
            Console.WriteLine($"  GetMin: {minStack2.GetMin()} (Expected: 3)");
            Console.WriteLine($"  Top: {minStack2.Top()} (Expected: 7)");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunMaximumDepthOfBinaryTree()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Maximum Depth of Binary Tree");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new MaximumDepthofBinaryTreeSolution();

            // Test case 1: [3,9,20,null,null,15,7] -> depth 3
            var root1 = new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            int result1 = solution.MaxDepth(root1);
            Console.WriteLine("Test 1: root = [3, 9, 20, null, null, 15, 7]");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine("Expected: 3\n");

            // Test case 2: [1,null,2] -> depth 2
            var root2 = new TreeNode(1, null, new TreeNode(2));
            int result2 = solution.MaxDepth(root2);
            Console.WriteLine("Test 2: root = [1, null, 2]");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine("Expected: 2\n");

            // Test case 3: [] -> depth 0
            int result3 = solution.MaxDepth(null);
            Console.WriteLine("Test 3: root = []");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine("Expected: 0\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunFibonacciNumber()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Fibonacci Number");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new FibonacciNumberSolution();

            // Test case 1
            int result1 = solution.Fib(2);
            Console.WriteLine("Test 1: n = 2");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine("Expected: 1\n");

            // Test case 2
            int result2 = solution.Fib(3);
            Console.WriteLine("Test 2: n = 3");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine("Expected: 2\n");

            // Test case 3
            int result3 = solution.Fib(4);
            Console.WriteLine("Test 3: n = 4");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine("Expected: 3\n");

            // Test case 4
            int result4 = solution.Fib(0);
            Console.WriteLine("Test 4: n = 0");
            Console.WriteLine($"Output: {result4}");
            Console.WriteLine("Expected: 0\n");

            // Test case 5
            int result5 = solution.Fib(1);
            Console.WriteLine("Test 5: n = 1");
            Console.WriteLine($"Output: {result5}");
            Console.WriteLine("Expected: 1\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunHouseRobber()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: House Robber");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new HouseRobberSolution();

            // Test case 1: [1,2,3,1] => 4
            int[] nums1 = { 1, 2, 3, 1 };
            int result1 = solution.Rob(nums1);
            Console.WriteLine("Test 1: nums = [1,2,3,1]");
            Console.WriteLine($"Output:   {result1}");
            Console.WriteLine("Expected: 4");
            Console.WriteLine("Explanation: Rob house 1 (1) then house 3 (3) = 4\n");

            // Test case 2: [2,7,9,3,1] => 12
            int[] nums2 = { 2, 7, 9, 3, 1 };
            int result2 = solution.Rob(nums2);
            Console.WriteLine("Test 2: nums = [2,7,9,3,1]");
            Console.WriteLine($"Output:   {result2}");
            Console.WriteLine("Expected: 12");
            Console.WriteLine("Explanation: Rob house 1 (2), house 3 (9), house 5 (1) = 12\n");

            // Test case 3: [2,1] => 2
            int[] nums3 = { 2, 1 };
            int result3 = solution.Rob(nums3);
            Console.WriteLine("Test 3: nums = [2,1]");
            Console.WriteLine($"Output:   {result3}");
            Console.WriteLine("Expected: 2\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunNumberOfIslands()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Number of Islands");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new NumberOfIslandsSolution();

            // Test case 1: 1 island
            char[][] grid1 =
            {
                new char[] { '1','1','1','1','0' },
                new char[] { '1','1','0','1','0' },
                new char[] { '1','1','0','0','0' },
                new char[] { '0','0','0','0','0' }
            };
            int result1 = solution.NumIslands(grid1);
            Console.WriteLine("Test 1: grid =");
            Console.WriteLine("  [1,1,1,1,0]");
            Console.WriteLine("  [1,1,0,1,0]");
            Console.WriteLine("  [1,1,0,0,0]");
            Console.WriteLine("  [0,0,0,0,0]");
            Console.WriteLine($"Output:   {result1}");
            Console.WriteLine("Expected: 1\n");

            // Test case 2: 3 islands
            char[][] grid2 =
            {
                new char[] { '1','1','0','0','0' },
                new char[] { '1','1','0','0','0' },
                new char[] { '0','0','1','0','0' },
                new char[] { '0','0','0','1','1' }
            };
            int result2 = solution.NumIslands(grid2);
            Console.WriteLine("Test 2: grid =");
            Console.WriteLine("  [1,1,0,0,0]");
            Console.WriteLine("  [1,1,0,0,0]");
            Console.WriteLine("  [0,0,1,0,0]");
            Console.WriteLine("  [0,0,0,1,1]");
            Console.WriteLine($"Output:   {result2}");
            Console.WriteLine("Expected: 3\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunLowestCommonAncestorBST()
        {
            Console.Clear();
            Console.WriteLine("══════════════════════════════════════════════════════════");
            Console.WriteLine("  Problem: Lowest Common Ancestor of a Binary Search Tree");
            Console.WriteLine("══════════════════════════════════════════════════════════\n");

            var solution = new LowestCommonAncestorOfBinarySearchTreeSolution();

            // Test case 1: root = [6,2,8,0,4,7,9], p = 2, q = 8 => 6
            var root1 = new TreeNode(6,
                new TreeNode(2, new TreeNode(0), new TreeNode(4)),
                new TreeNode(8, new TreeNode(7), new TreeNode(9)));
            var result1 = solution.LowestCommonAncestor(root1, new TreeNode(2), new TreeNode(8));
            Console.WriteLine("Test 1: root = [6,2,8,0,4,7,9], p = 2, q = 8");
            Console.WriteLine($"Output:   {result1.val}");
            Console.WriteLine("Expected: 6\n");

            // Test case 2: root = [6,2,8,0,4,7,9], p = 2, q = 4 => 2
            var root2 = new TreeNode(6,
                new TreeNode(2, new TreeNode(0), new TreeNode(4)),
                new TreeNode(8, new TreeNode(7), new TreeNode(9)));
            var result2 = solution.LowestCommonAncestor(root2, new TreeNode(2), new TreeNode(4));
            Console.WriteLine("Test 2: root = [6,2,8,0,4,7,9], p = 2, q = 4");
            Console.WriteLine($"Output:   {result2.val}");
            Console.WriteLine("Expected: 2\n");

            // Test case 3: root = [2,1], p = 2, q = 1 => 2
            var root3 = new TreeNode(2, new TreeNode(1), null);
            var result3 = solution.LowestCommonAncestor(root3, new TreeNode(2), new TreeNode(1));
            Console.WriteLine("Test 3: root = [2,1], p = 2, q = 1");
            Console.WriteLine($"Output:   {result3.val}");
            Console.WriteLine("Expected: 2\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunAddTwoNumbers()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Add Two Numbers");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new AddTwoNumbersSolution();

            // Test case 1: [2,4,3] + [5,6,4] = [7,0,8] (342 + 465 = 807)
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var result1 = solution.AddTwoNumbers(l1, l2);
            Console.WriteLine("Test 1: l1 = [2,4,3], l2 = [5,6,4]");
            Console.Write("Output:   [");
            PrintList(result1);
            Console.WriteLine("]");
            Console.WriteLine("Expected: [7,0,8]\n");

            // Test case 2: [0] + [0] = [0]
            var l3 = new ListNode(0);
            var l4 = new ListNode(0);
            var result2 = solution.AddTwoNumbers(l3, l4);
            Console.WriteLine("Test 2: l1 = [0], l2 = [0]");
            Console.Write("Output:   [");
            PrintList(result2);
            Console.WriteLine("]");
            Console.WriteLine("Expected: [0]\n");

            // Test case 3: [9,9,9,9,9,9,9] + [9,9,9,9] = [8,9,9,9,0,0,0,1]
            var l5 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            var l6 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            var result3 = solution.AddTwoNumbers(l5, l6);
            Console.WriteLine("Test 3: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]");
            Console.Write("Output:   [");
            PrintList(result3);
            Console.WriteLine("]");
            Console.WriteLine("Expected: [8,9,9,9,0,0,0,1]\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunProductOfArrayExceptSelf()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════");
            Console.WriteLine("  Problem: Product of Array Except Self");
            Console.WriteLine("═══════════════════════════════════════════════\n");

            var solution = new ProductOfArrayExceptSelfSolution();

            // Test case 1: [1,2,3,4] => [24,12,8,6]
            int[] nums1 = { 1, 2, 3, 4 };
            int[] result1 = solution.ProductExceptSelf(nums1);
            Console.WriteLine("Test 1: nums = [1,2,3,4]");
            Console.WriteLine($"Output:   [{string.Join(",", result1)}]");
            Console.WriteLine("Expected: [24,12,8,6]\n");

            // Test case 2: [-1,1,0,-3,3] => [0,0,9,0,0]
            int[] nums2 = { -1, 1, 0, -3, 3 };
            int[] result2 = solution.ProductExceptSelf(nums2);
            Console.WriteLine("Test 2: nums = [-1,1,0,-3,3]");
            Console.WriteLine($"Output:   [{string.Join(",", result2)}]");
            Console.WriteLine("Expected: [0,0,9,0,0]\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunMajorityElement()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Majority Element");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new MajorityElementSolution();

            // Test case 1: [3,2,3] => 3
            int[] nums1 = { 3, 2, 3 };
            int result1 = solution.MajorityElement(nums1);
            Console.WriteLine("Test 1: nums = [3,2,3]");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine("Expected: 3\n");

            // Test case 2: [2,2,1,1,1,2,2] => 2
            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            int result2 = solution.MajorityElement(nums2);
            Console.WriteLine("Test 2: nums = [2,2,1,1,1,2,2]");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine("Expected: 2\n");

            // Test case 3: [1] => 1
            int[] nums3 = { 1 };
            int result3 = solution.MajorityElement(nums3);
            Console.WriteLine("Test 3: nums = [1]");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine("Expected: 1\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunKthLargestElement()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════");
            Console.WriteLine("  Problem: Kth Largest Element in an Array");
            Console.WriteLine("═══════════════════════════════════════════════\n");

            var solution = new KthLargestElementSolution();

            // Test case 1: [3,2,1,5,6,4], k=2 => 5
            int[] nums1 = { 3, 2, 1, 5, 6, 4 };
            int result1 = solution.FindKthLargest(nums1, 2);
            Console.WriteLine("Test 1: nums = [3,2,1,5,6,4], k = 2");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine("Expected: 5\n");

            // Test case 2: [3,2,3,1,2,4,5,5,6], k=4 => 4
            int[] nums2 = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int result2 = solution.FindKthLargest(nums2, 4);
            Console.WriteLine("Test 2: nums = [3,2,3,1,2,4,5,5,6], k = 4");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine("Expected: 4\n");

            // Test case 3: [1], k=1 => 1
            int[] nums3 = { 1 };
            int result3 = solution.FindKthLargest(nums3, 1);
            Console.WriteLine("Test 3: nums = [1], k = 1");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine("Expected: 1\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunBinaryTreeLevelOrderTraversal()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════════════");
            Console.WriteLine("  Problem: Binary Tree Level Order Traversal");
            Console.WriteLine("═══════════════════════════════════════════════\n");

            var solution = new BinaryTreeLevelOrderTraversalSolution();

            // Test case 1: [3,9,20,null,null,15,7] => [[3],[9,20],[15,7]]
            var root1 = new TreeNode(3,
                new TreeNode(9),
                new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            var result1 = solution.LevelOrder(root1);
            Console.WriteLine("Test 1: root = [3,9,20,null,null,15,7]");
            Console.WriteLine($"Output: [{string.Join(", ", result1.Select(l => "[" + string.Join(",", l) + "]"))}]");
            Console.WriteLine("Expected: [[3],[9,20],[15,7]]\n");

            // Test case 2: [1] => [[1]]
            var root2 = new TreeNode(1);
            var result2 = solution.LevelOrder(root2);
            Console.WriteLine("Test 2: root = [1]");
            Console.WriteLine($"Output: [{string.Join(", ", result2.Select(l => "[" + string.Join(",", l) + "]"))}]");
            Console.WriteLine("Expected: [[1]]\n");

            // Test case 3: null => []
            var result3 = solution.LevelOrder(null);
            Console.WriteLine("Test 3: root = null");
            Console.WriteLine($"Output: [{string.Join(", ", result3.Select(l => "[" + string.Join(",", l) + "]"))}]");
            Console.WriteLine("Expected: []\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunMaximumDepthOfNaryTree()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Maximum Depth of N-ary Tree");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new MaximumDepthofNaryTreeSolution();

            // Test case 1: [1,null,3,2,4,null,5,6] => depth 3
            var root1 = new Node(1, new List<Node>
            {
                new Node(3, new List<Node> { new Node(5), new Node(6) }),
                new Node(2),
                new Node(4)
            });
            int result1 = solution.MaxDepth(root1);
            Console.WriteLine("Test 1: root = [1,null,3,2,4,null,5,6]");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine("Expected: 3\n");

            // Test case 2: null => depth 0
            int result2 = solution.MaxDepth(null);
            Console.WriteLine("Test 2: root = null");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine("Expected: 0\n");

            // Test case 3: single node => depth 1
            var root3 = new Node(1, new List<Node>());
            int result3 = solution.MaxDepth(root3);
            Console.WriteLine("Test 3: root = [1]");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine("Expected: 1\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunClimbingStairs()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Climbing Stairs");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new StairClimbersSolution();

            // Test case 1
            int result1 = solution.ClimbStairs(2);
            Console.WriteLine("Test 1: n = 2");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine("Expected: 2");
            Console.WriteLine("Explanation: 1+1, 2\n");

            // Test case 2
            int result2 = solution.ClimbStairs(3);
            Console.WriteLine("Test 2: n = 3");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine("Expected: 3");
            Console.WriteLine("Explanation: 1+1+1, 1+2, 2+1\n");

            // Test case 3
            int result3 = solution.ClimbStairs(5);
            Console.WriteLine("Test 3: n = 5");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine("Expected: 8\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunSearchInsertPosition()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Search Insert Position");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new SearchInsertPositionSolution();

            // Test case 1
            int[] nums1 = { 1, 3, 5, 6 };
            int target1 = 5;
            int result1 = solution.SearchInsert(nums1, target1);
            Console.WriteLine($"Test 1: nums = [{string.Join(", ", nums1)}], target = {target1}");
            Console.WriteLine($"Output: {result1}");
            Console.WriteLine($"Expected: 2\n");

            // Test case 2
            int[] nums2 = { 1, 3, 5, 6 };
            int target2 = 2;
            int result2 = solution.SearchInsert(nums2, target2);
            Console.WriteLine($"Test 2: nums = [{string.Join(", ", nums2)}], target = {target2}");
            Console.WriteLine($"Output: {result2}");
            Console.WriteLine($"Expected: 1\n");

            // Test case 3
            int[] nums3 = { 1, 3, 5, 6 };
            int target3 = 7;
            int result3 = solution.SearchInsert(nums3, target3);
            Console.WriteLine($"Test 3: nums = [{string.Join(", ", nums3)}], target = {target3}");
            Console.WriteLine($"Output: {result3}");
            Console.WriteLine($"Expected: 4\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }

        static void RunMergeSortedArray()
        {
            Console.Clear();
            Console.WriteLine("═══════════════════════════════════════");
            Console.WriteLine("  Problem: Merge Sorted Array");
            Console.WriteLine("═══════════════════════════════════════\n");

            var solution = new MergeSortedArraySolution();

            // Test case 1
            int[] nums1_1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2_1 = { 2, 5, 6 };
            solution.Merge(nums1_1, 3, nums2_1, 3);
            Console.WriteLine("Test 1: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3");
            Console.WriteLine($"Output: [{string.Join(", ", nums1_1)}]");
            Console.WriteLine("Expected: [1, 2, 2, 3, 5, 6]\n");

            // Test case 2
            int[] nums1_2 = { 1 };
            int[] nums2_2 = { };
            solution.Merge(nums1_2, 1, nums2_2, 0);
            Console.WriteLine("Test 2: nums1 = [1], m = 1, nums2 = [], n = 0");
            Console.WriteLine($"Output: [{string.Join(", ", nums1_2)}]");
            Console.WriteLine("Expected: [1]\n");

            // Test case 3
            int[] nums1_3 = { 0 };
            int[] nums2_3 = { 1 };
            solution.Merge(nums1_3, 0, nums2_3, 1);
            Console.WriteLine("Test 3: nums1 = [0], m = 0, nums2 = [1], n = 1");
            Console.WriteLine($"Output: [{string.Join(", ", nums1_3)}]");
            Console.WriteLine("Expected: [1]\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
