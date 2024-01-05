/* Write your T-SQL query statement below */

-- activity_type enum {'start', 'end'}
-- start - end for each

select a.machine_id,

round (avg (case WHEN a.activity_type = 'end' THEN a.timestamp else -a.timestamp END) *2, 3) processing_time

from Activity a
group by machine_id