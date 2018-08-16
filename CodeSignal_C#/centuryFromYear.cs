/// <summary>
//  Given a year, return the century it is in.
//  The first century spans from the year 1 up to and including the year 100, 
//  the second - from the year 101 up to and including the year 200, etc.
/// </summary>
/// <param name="year">Guaranteed constraints:1 ≤ year ≤ 2005.</param>
/// <returns>The number of the century the year is in.</returns>


int centuryFromYear(int year) {
    if (year / 100 < 1) 
    {
        return 1;
    }
    else
        if (year % 100 > 0)
        {
            return year / 100 + 1;
        }
        else
            return year /100;
}