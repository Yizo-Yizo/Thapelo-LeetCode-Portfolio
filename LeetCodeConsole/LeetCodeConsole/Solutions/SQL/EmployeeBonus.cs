namespace LeetCodeConsole.Solutions.SQL
{
    public class EmployeeBonus
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("  SQL Problem: Employee Bonus");
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP\n");

            Console.WriteLine("Table: Employee");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| Column Name | Type    |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| empId       | int     |");
            Console.WriteLine("| name        | varchar |");
            Console.WriteLine("| supervisor  | int     |");
            Console.WriteLine("| salary      | int     |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("empId is the column with unique values for this table.");
            Console.WriteLine("Each row indicates the name and ID of an employee, their salary, and manager id.\n");

            Console.WriteLine("Table: Bonus");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("| Column Name | Type |");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("| empId       | int  |");
            Console.WriteLine("| bonus       | int  |");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("empId is the column of unique values for this table.");
            Console.WriteLine("empId is a foreign key to empId from the Employee table.");
            Console.WriteLine("Each row contains the id of an employee and their respective bonus.\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Write a solution to report the name and bonus amount of each employee");
            Console.WriteLine("who satisfies either of the following:");
            Console.WriteLine("- The employee has a bonus less than 1000.");
            Console.WriteLine("- The employee did not get any bonus.\n");

            Console.WriteLine("EXAMPLE:");
            Console.WriteLine("Input:");
            Console.WriteLine("Employee table:");
            Console.WriteLine("+-------+--------+------------+--------+");
            Console.WriteLine("| empId | name   | supervisor | salary |");
            Console.WriteLine("+-------+--------+------------+--------+");
            Console.WriteLine("| 3     | Brad   | null       | 4000   |");
            Console.WriteLine("| 1     | John   | 3          | 1000   |");
            Console.WriteLine("| 2     | Dan    | 3          | 2000   |");
            Console.WriteLine("| 4     | Thomas | 3          | 4000   |");
            Console.WriteLine("+-------+--------+------------+--------+\n");

            Console.WriteLine("Bonus table:");
            Console.WriteLine("+-------+-------+");
            Console.WriteLine("| empId | bonus |");
            Console.WriteLine("+-------+-------+");
            Console.WriteLine("| 2     | 500   |");
            Console.WriteLine("| 4     | 2000  |");
            Console.WriteLine("+-------+-------+\n");

            Console.WriteLine("Output:");
            Console.WriteLine("+------+-------+");
            Console.WriteLine("| name | bonus |");
            Console.WriteLine("+------+-------+");
            Console.WriteLine("| Brad | null  |");
            Console.WriteLine("| John | null  |");
            Console.WriteLine("| Dan  | 500   |");
            Console.WriteLine("+------+-------+\n");

            Console.WriteLine("Explanation:");
            Console.WriteLine("- Brad: No bonus record (null)");
            Console.WriteLine("- John: No bonus record (null)");
            Console.WriteLine("- Dan: Bonus is 500, which is less than 1000");
            Console.WriteLine("- Thomas: Bonus is 2000, which is >= 1000 (excluded)\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("                                                                     \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SELECT name, bonus");
            Console.WriteLine("FROM  Employee E");
            Console.WriteLine("LEFT JOIN Bonus B");
            Console.WriteLine("ON E.empId = B.empId");
            Console.WriteLine("WHERE B.bonus < 1000 OR B.bonus IS NULL");
            Console.ResetColor();

            Console.WriteLine("\n                                                                     ");
            Console.WriteLine("APPROACH:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("1. Use LEFT JOIN to preserve all employees, even without bonuses");
            Console.WriteLine("2. Join on empId to match employees with their bonus records");
            Console.WriteLine("3. Filter WHERE bonus < 1000 OR bonus IS NULL");
            Console.WriteLine("   - This catches employees with small bonuses AND no bonus record");
            Console.WriteLine("4. Return name and bonus columns\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("Time Complexity: O(n + m) - where n = employees, m = bonuses");
            Console.WriteLine("Space Complexity: O(k) - where k = number of qualifying employees\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
