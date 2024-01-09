/* Write your T-SQL query statement below */

SELECT Department, Employee, Salary
FROM (
    SELECT 
        d.name as Department, 
        e.name as Employee, 
        e.salary as Salary,
    
    --  Assigns ranks in a way where equal values receive the same rank.
        DENSE_RANK() OVER (PARTITION BY e.departmentId ORDER BY e.salary DESC) as rank
    FROM Employee e
    LEFT JOIN Department d ON e.departmentId = d.id
) subquery
WHERE rank = 1;
