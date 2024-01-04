/* Write your T-SQL query statement below */

select x, y, z,
    -- Check if 2 sides added are > than the 3rd
    CASE WHEN x + y > z and y + z > x and x + z > y then 'Yes' 
    else 'No' end triangle
from Triangle
