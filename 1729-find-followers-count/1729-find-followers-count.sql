/* Write your T-SQL query statement below */

select user_id, count(follower_id) AS followers_count
from Followers
Group by user_id 