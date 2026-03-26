namespace LeetCodeConsole.Solutions.SQL
{
    public class DepartmentTopThreeSalaries
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("  SQL Problem: Department Top Three Salaries");
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP\n");

            Console.WriteLine("Table: Employee");
            Console.WriteLine("+--------------+---------+");
            Console.WriteLine("| Column Name  | Type    |");
            Console.WriteLine("+--------------+---------+");
            Console.WriteLine("| id           | int     |");
            Console.WriteLine("| name         | varchar |");
            Console.WriteLine("| salary       | int     |");
            Console.WriteLine("| departmentId | int     |");
            Console.WriteLine("+--------------+---------+");
            Console.WriteLine("id is the primary key. departmentId is a foreign key to Department.id.\n");

            Console.WriteLine("Table: Department");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| Column Name | Type    |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| id          | int     |");
            Console.WriteLine("| name        | varchar |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("id is the primary key.\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("A company's executives are interested in seeing who earns the most money in each");
            Console.WriteLine("of the company's departments. A high earner in a department is an employee who");
            Console.WriteLine("has a salary in the top three unique salaries for that department.");
            Console.WriteLine("Write a solution to find the employees who are high earners in each department.\n");

            Console.WriteLine("EXAMPLE 1:");
            Console.WriteLine("Input:");
            Console.WriteLine("Employee table:");
            Console.WriteLine("+----+-------+--------+--------------+");
            Console.WriteLine("| id | name  | salary | departmentId |");
            Console.WriteLine("+----+-------+--------+--------------+");
            Console.WriteLine("| 1  | Joe   | 85000  | 1            |");
            Console.WriteLine("| 2  | Henry | 80000  | 2            |");
            Console.WriteLine("| 3  | Sam   | 60000  | 2            |");
            Console.WriteLine("| 4  | Max   | 90000  | 1            |");
            Console.WriteLine("| 5  | Janet | 69000  | 1            |");
            Console.WriteLine("| 6  | Randy | 85000  | 1            |");
            Console.WriteLine("| 7  | Will  | 70000  | 1            |");
            Console.WriteLine("+----+-------+--------+--------------+");
            Console.WriteLine("Department table:");
            Console.WriteLine("+----+-------+");
            Console.WriteLine("| id | name  |");
            Console.WriteLine("+----+-------+");
            Console.WriteLine("| 1  | IT    |");
            Console.WriteLine("| 2  | Sales |");
            Console.WriteLine("+----+-------+");
            Console.WriteLine("\nOutput:");
            Console.WriteLine("+------------+----------+--------+");
            Console.WriteLine("| Department | Employee | Salary |");
            Console.WriteLine("+------------+----------+--------+");
            Console.WriteLine("| IT         | Max      | 90000  |");
            Console.WriteLine("| IT         | Joe      | 85000  |");
            Console.WriteLine("| IT         | Randy    | 85000  |");
            Console.WriteLine("| IT         | Will     | 70000  |");
            Console.WriteLine("| Sales      | Henry    | 80000  |");
            Console.WriteLine("| Sales      | Sam      | 60000  |");
            Console.WriteLine("+------------+----------+--------+\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("                                                                     \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WITH RankedEmployees AS (");
            Console.WriteLine("    SELECT");
            Console.WriteLine("        d.name AS Department,");
            Console.WriteLine("        e.name AS Employee,");
            Console.WriteLine("        e.salary AS Salary,");
            Console.WriteLine("        DENSE_RANK() OVER (");
            Console.WriteLine("            PARTITION BY e.departmentId");
            Console.WriteLine("            ORDER BY e.salary DESC");
            Console.WriteLine("        ) AS SalaryRank");
            Console.WriteLine("    FROM Employee e");
            Console.WriteLine("    JOIN Department d ON e.departmentId = d.id");
            Console.WriteLine(")");
            Console.WriteLine("SELECT");
            Console.WriteLine("    Department,");
            Console.WriteLine("    Employee,");
            Console.WriteLine("    Salary");
            Console.WriteLine("FROM RankedEmployees");
            Console.WriteLine("WHERE SalaryRank <= 3;");
            Console.ResetColor();

            Console.WriteLine("\n                                                                     ");
            Console.WriteLine("APPROACH:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("1. JOIN Employee and Department tables to get department names");
            Console.WriteLine("2. Use DENSE_RANK() partitioned by departmentId, ordered by salary DESC");
            Console.WriteLine("   - DENSE_RANK ensures tied salaries share the same rank");
            Console.WriteLine("3. Filter WHERE SalaryRank <= 3 to get top 3 unique salary tiers\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("Time Complexity: O(n log n) - due to sorting within each partition");
            Console.WriteLine("Space Complexity: O(n) - for the CTE result set\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
