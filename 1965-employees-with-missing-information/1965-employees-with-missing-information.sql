/* Write your T-SQL query statement below */

select 
    case when e.employee_id is NULL then s.employee_id
    else e.employee_id  end as employee_id FROM Employees e
    
    FULL OUTER JOIN Salaries s ON e.employee_id = s.employee_id
    WHERE e.employee_id IS NULL or s.employee_id IS NULL   
    order by employee_id