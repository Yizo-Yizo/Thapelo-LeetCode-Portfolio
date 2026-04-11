namespace LeetCodeConsole.Solutions.SQL
{
    public class TripAndUsers
    {
        public static void DisplayProblem()
        {
            Console.Clear();
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP");
            Console.WriteLine("  SQL Problem: Trips and Users");
            Console.WriteLine("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP\n");

            Console.WriteLine("Table: Trips");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| Column Name | Type    |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("| id          | int     |");
            Console.WriteLine("| client_id   | int     |");
            Console.WriteLine("| driver_id   | int     |");
            Console.WriteLine("| city_id     | int     |");
            Console.WriteLine("| status      | enum    |");
            Console.WriteLine("| request_at  | varchar |");
            Console.WriteLine("+-------------+---------+");
            Console.WriteLine("id is the primary key. client_id and driver_id are foreign keys to Users.users_id.");
            Console.WriteLine("Status is one of: 'completed', 'cancelled_by_driver', 'cancelled_by_client'.\n");

            Console.WriteLine("Table: Users");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("| Column Name | Type |");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("| users_id    | int  |");
            Console.WriteLine("| banned      | enum |");
            Console.WriteLine("| role        | enum |");
            Console.WriteLine("+-------------+------+");
            Console.WriteLine("users_id is the primary key. banned is 'Yes' or 'No'.\n");

            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Find the cancellation rate of requests with unbanned users (both client and");
            Console.WriteLine("driver must not be banned) each day between '2013-10-01' and '2013-10-03'.");
            Console.WriteLine("Round Cancellation Rate to two decimal points.\n");

            Console.WriteLine("EXAMPLE 1:");
            Console.WriteLine("Output:");
            Console.WriteLine("+------------+-------------------+");
            Console.WriteLine("| Day        | Cancellation Rate |");
            Console.WriteLine("+------------+-------------------+");
            Console.WriteLine("| 2013-10-01 | 0.33              |");
            Console.WriteLine("| 2013-10-02 | 0.00              |");
            Console.WriteLine("| 2013-10-03 | 0.50              |");
            Console.WriteLine("+------------+-------------------+\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("SOLUTION:");
            Console.WriteLine("                                                                     \n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("WITH ValidTrips AS (");
            Console.WriteLine("    SELECT");
            Console.WriteLine("        t.request_at AS Day,");
            Console.WriteLine("        t.status");
            Console.WriteLine("    FROM Trips t");
            Console.WriteLine("    JOIN Users client ON t.client_id = client.users_id");
            Console.WriteLine("    JOIN Users driver ON t.driver_id = driver.users_id");
            Console.WriteLine("    WHERE client.banned = 'No'");
            Console.WriteLine("      AND driver.banned = 'No'");
            Console.WriteLine("      AND t.request_at BETWEEN '2013-10-01' AND '2013-10-03'");
            Console.WriteLine(")");
            Console.WriteLine("SELECT");
            Console.WriteLine("    Day,");
            Console.WriteLine("    ROUND(");
            Console.WriteLine("        CAST(SUM(CASE WHEN status LIKE '%cancelled%' THEN 1 ELSE 0 END) AS FLOAT)");
            Console.WriteLine("        / COUNT(*),");
            Console.WriteLine("        2");
            Console.WriteLine("    ) AS [Cancellation Rate]");
            Console.WriteLine("FROM ValidTrips");
            Console.WriteLine("GROUP BY Day");
            Console.WriteLine("ORDER BY Day;");
            Console.ResetColor();

            Console.WriteLine("\n                                                                     ");
            Console.WriteLine("APPROACH:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("1. CTE filters trips to only include unbanned clients and drivers");
            Console.WriteLine("2. JOIN Users twice — once for client, once for driver");
            Console.WriteLine("3. Filter date range with BETWEEN");
            Console.WriteLine("4. CASE WHEN counts cancelled trips (both cancelled_by_driver and cancelled_by_client)");
            Console.WriteLine("5. ROUND(..., 2) formats the rate to two decimal places\n");

            Console.WriteLine("                                                                     ");
            Console.WriteLine("COMPLEXITY:");
            Console.WriteLine("                                                                     ");
            Console.WriteLine("Time Complexity: O(n log n) - due to GROUP BY and ORDER BY");
            Console.WriteLine("Space Complexity: O(n) - for the CTE result set\n");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
