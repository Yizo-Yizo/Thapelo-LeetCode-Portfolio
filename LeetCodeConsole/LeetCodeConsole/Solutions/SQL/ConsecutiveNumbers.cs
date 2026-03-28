namespace LeetCodeConsole.Solutions.SQL
{
    public class ConsecutiveNumbers
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("  SQL Problem: Consecutive Numbers");
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP\n");

            Console.WriteLine("Table: Logs");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| Column Name | Type    |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| id          | int     |");
            Console.WriteLine("| num         | varchar |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("id is the primary key (autoincrement starting from 1).\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Find all numbers that appear at least three times consecutively.");
            Console.WriteLine("Return the result table in any order.\n");

            Console.WriteLine("EXAMPLE 1:");
            Console.WriteLine("Input:");
            Console.WriteLine("Logs table:");
            Console.WriteLine("+----+-----+");
            Console.WriteLine("| id | num |");
            Console.WriteLine("+----+-----+");
            Console.WriteLine("| 1  | 1   |");
            Console.WriteLine("| 2  | 1   |");
            Console.WriteLine("| 3  | 1   |");
            Console.WriteLine("| 4  | 2   |");
            Console.WriteLine("| 5  | 1   |");
            Console.WriteLine("| 6  | 2   |");
            Console.WriteLine("| 7  | 2   |");
            Console.WriteLine("+----+-----+");
            Console.WriteLine("\nOutput:");
            Console.WriteLine("+-----------------+");
            Console.WriteLine("| ConsecutiveNums |");
            Console.WriteLine("+-----------------+");
            Console.WriteLine("| 1               |");
            Console.WriteLine("+-----------------+");
            Console.WriteLine("Explanation: 1 is the only number that appears consecutively at least 3 times.\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("                                                                     \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WITH RankedLogs AS (");
            Console.WriteLine("    SELECT");
            Console.WriteLine("        num,");
            Console.WriteLine("        LAG(num, 1) OVER (ORDER BY id) AS prev1,");
            Console.WriteLine("        LAG(num, 2) OVER (ORDER BY id) AS prev2");
            Console.WriteLine("    FROM Logs");
            Console.WriteLine(")");
            Console.WriteLine("SELECT DISTINCT num AS ConsecutiveNums");
            Console.WriteLine("FROM RankedLogs");
            Console.WriteLine("WHERE num = prev1 AND num = prev2;");
            Console.ResetColor();

            Console.WriteLine("\n                                                                     ");
            Console.WriteLine("APPROACH:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("1. Use a CTE with LAG() to look back 1 and 2 rows for each row");
            Console.WriteLine("2. LAG(num, 1) gets the immediately preceding number");
            Console.WriteLine("3. LAG(num, 2) gets the number two rows before");
            Console.WriteLine("4. WHERE num = prev1 AND num = prev2 finds three consecutive matches");
            Console.WriteLine("5. DISTINCT removes duplicates in case a number appears 4+ times\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("Time Complexity: O(n log n) - due to window function ordering");
            Console.WriteLine("Space Complexity: O(n) - for the CTE result set\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
