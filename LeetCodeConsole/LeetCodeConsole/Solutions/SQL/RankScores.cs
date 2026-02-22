namespace LeetCodeConsole.Solutions.SQL
{
    public class RankScores
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("  SQL Problem: Rank Scores");
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP\n");

            Console.WriteLine("Table: Scores");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| Column Name | Type    |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| id          | int     |");
            Console.WriteLine("| score       | decimal |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("id is the primary key for this table.");
            Console.WriteLine("Each row contains the score of a game. Score is a floating point value with two decimal places.\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Write a solution to find the rank of the scores. The ranking rules:");
            Console.WriteLine("- Scores should be ranked from highest to lowest.");
            Console.WriteLine("- If there is a tie, both scores should have the same ranking.");
            Console.WriteLine("- After a tie, the next ranking number should be the next consecutive integer (no holes).");
            Console.WriteLine("Return the result table ordered by score in descending order.\n");

            Console.WriteLine("EXAMPLE:");
            Console.WriteLine("Input:");
            Console.WriteLine("Scores table:");
            Console.WriteLine("+----+-------+");
            Console.WriteLine("| id | score |");
            Console.WriteLine("+----+-------+");
            Console.WriteLine("| 1  | 3.50  |");
            Console.WriteLine("| 2  | 3.65  |");
            Console.WriteLine("| 3  | 4.00  |");
            Console.WriteLine("| 4  | 3.85  |");
            Console.WriteLine("| 5  | 4.00  |");
            Console.WriteLine("| 6  | 3.65  |");
            Console.WriteLine("+----+-------+\n");

            Console.WriteLine("Output:");
            Console.WriteLine("+-------+------+");
            Console.WriteLine("| score | rank |");
            Console.WriteLine("+-------+------+");
            Console.WriteLine("| 4.00  | 1    |");
            Console.WriteLine("| 4.00  | 1    |");
            Console.WriteLine("| 3.85  | 2    |");
            Console.WriteLine("| 3.65  | 3    |");
            Console.WriteLine("| 3.65  | 3    |");
            Console.WriteLine("| 3.50  | 4    |");
            Console.WriteLine("+-------+------+\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("                                                                     \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SELECT");
            Console.WriteLine("    score,");
            Console.WriteLine("    DENSE_RANK() OVER (ORDER BY score DESC) AS rank");
            Console.WriteLine("FROM Scores");
            Console.WriteLine("ORDER BY score DESC");
            Console.ResetColor();

            Console.WriteLine("\n                                                                     ");
            Console.WriteLine("APPROACH:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("1. Use DENSE_RANK() window function to assign ranks without gaps");
            Console.WriteLine("2. ORDER BY score DESC inside OVER() ranks highest scores first");
            Console.WriteLine("3. Ties receive the same rank; next rank is consecutive (no holes)");
            Console.WriteLine("4. Final ORDER BY score DESC satisfies the required output order\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("Time Complexity: O(n log n) - due to sorting for the window function");
            Console.WriteLine("Space Complexity: O(n) - for the result set\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
