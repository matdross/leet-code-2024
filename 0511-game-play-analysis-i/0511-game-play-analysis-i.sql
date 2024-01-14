/* Write your T-SQL query statement below */

select player_id, first_login = MIN(event_date)
from Activity
group by player_id