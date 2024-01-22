/*
    Problem
    --------------------------------------------------------------------------------
    Given a year, return the century it is in.
    The first century spans from the year 1 up to and including the year 100, 
    the second - from the year 101 up to and including the year 200, etc.
    
    Guaranteed constraints:
    1 ≤ year ≤ 2005.
*/

/*
    Solution
    --------------------------------------------------------------------------------
    The word "century" defines "a period of one hundred years". The conceptual
    trick here is that the years 1 AC until 100 AC are _already_ within the 1st
    century, as there is no "century zero".
    For example, the year 2000 was still in the 20th century, but on 2001 started
    the 21st century.
    One way to solve this could be calculating how many hundreds of years, or 
    centuries, contains a given date (year input value).
    So if a given year is a multiple of 100 (divisible by 100 with 0 remainder),
    then such year is still in the previous century (e.g. 2000, 900, 1800).
*/

int solution(int year)
{
    var century = 0;

    var hundredsOfYears = Math.Truncate((double)year / 100);
    var turnOfTheCentury = (double)year % 100 == 0d;
    
    if (turnOfTheCentury)
    {
        century = (int)hundredsOfYears;
    }
    else
    {
        century = (int)hundredsOfYears + 1;
    }
    
    return century;
}