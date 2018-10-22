/*
1. 
use pubs;
go

2.
select * from authors where state = 'CA';
go

3.
select title_id, title, price from titles;
go

4.
alter table dbo.titles add adjusted_price as (price + (price * .10));
go 

5.
select max(titles.price) from titles;
go

6.
select title, sales.* from titles, sales;
go

8.
select title as Title, stor_name as Store_Name, ord_date as Order_Date,
	qty as Quantity
	from titles, stores, sales;
go
 
*/