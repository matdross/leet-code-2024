/* Write your T-SQL query statement below */

SELECT 
    tr.request_at AS Day, 
    CAST(CAST(SUM(CASE 
                WHEN tr.status IN ('cancelled_by_driver', 'cancelled_by_client') THEN 1 
                ELSE 0 
             END) AS FLOAT) / COUNT(*) AS NUMERIC(18,2)) AS 'Cancellation Rate'
FROM 
    Trips AS tr
    INNER JOIN Users AS ci ON tr.client_id = ci.users_id
    INNER JOIN Users AS dr ON tr.driver_id = dr.users_id
WHERE 
    ci.banned = 'No' AND dr.banned = 'No' 
    AND tr.request_at BETWEEN '2013-10-01' AND '2013-10-03'
GROUP BY 
    tr.request_at
