/* Write your T-SQL query statement below */

select *
from Users
where mail like '[a-zA-Z]%@leetcode.com'
and mail not like '%[^a-zA-Z0-9_.-]%@leetcode.com'