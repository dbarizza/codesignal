-- You recently started working in the IT department of a large store. You were put in charge of the inventory database availableItems, which has the following structure:

-- id: unique item ID;
-- item_name: the name of the item;
-- item_type: the type of the item.
-- Note that it is possible for items that are of different types to have the same names.

-- One of the most common operations performed on this database is querying the number of specific items available at the store. Since the database is quite large, queries of this type can take up too much time. You have decided to solve this problem by creating a new table that contains item counts for all available items.

-- Given the availableItems table, compose a results table that has the following three columns: item_name, item_type and item_count, containing the names of the items, their types, and the amount of those items, respectively. The table should be sorted in ascending order by item type, with items of the same type sorted in ascending order by their names.

/*Please add ; after each select statement*/

CREATE PROCEDURE itemCounts()
BEGIN
    select item_name, item_type, count(*) as item_count
	from availableItems  
    group by item_name, item_type
    order by item_type, item_name;
END