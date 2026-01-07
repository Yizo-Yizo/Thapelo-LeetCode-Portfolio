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
    }
}
