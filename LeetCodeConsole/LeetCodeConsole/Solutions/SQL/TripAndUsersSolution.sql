/* Write your T-SQL query statement below */

WITH ValidTrips AS (
    SELECT 
        t.request_at AS Day,
        t.status
    FROM Trips t
    JOIN Users client ON t.client_id = client.users_id
    JOIN Users driver ON t.driver_id = driver.users_id
    WHERE client.banned = 'No'
      AND driver.banned = 'No'
      AND t.request_at BETWEEN '2013-10-01' AND '2013-10-03'
)
SELECT 
    Day,
    ROUND(
        CAST(SUM(CASE WHEN status LIKE '%cancelled%' THEN 1 ELSE 0 END) AS FLOAT) 
        / COUNT(*), 
        2
    ) AS [Cancellation Rate]
FROM ValidTrips
GROUP BY Day
ORDER BY Day;   -- optional, but makes output consistent