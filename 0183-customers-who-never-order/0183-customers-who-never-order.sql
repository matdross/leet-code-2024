/* Write your T-SQL query statement below */
select name as Customers
    from Customers as c
    left join Orders as o on o.customerId = c.id
    where customerId is null