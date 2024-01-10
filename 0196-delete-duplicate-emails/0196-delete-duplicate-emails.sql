/* Write your T-SQL query statement below */

begin transaction

delete from Person
where id not in (
    select MIN(id) -- or max for most recent
    from Person
    group by email
)

commit transaction
-- rollback transaction