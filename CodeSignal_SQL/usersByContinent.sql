-- You are curious about the geographical distribution of CodeSignal users, so you have created a list of countries along with the number of registered users from each. Your task now is to calculate the number of users on each continent.

-- The information about the countries is stored in a table countries, which has 3 columns:

-- country: the name of the country;
-- continent: the name of the continent where the country is located;
-- users: the number of users registered on CodeSignal in the country.
-- The answer should be a table with 2 columns, continent and users, sorted by the number of users in decreasing order.

/*Please add ; after each select statement*/
CREATE PROCEDURE usersByContinent()
BEGIN
	select continent, sum(users) as users
    from countries
    group by continent
    order by sum(users) desc;
END