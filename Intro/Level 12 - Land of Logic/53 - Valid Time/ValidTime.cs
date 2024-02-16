/*  
    Problem
    --------------------------------------------------------------------------------
    Check if the given string is a correct time representation of the 24-hour
    clock.
    
    Example
    
    For time = "13:58", the output should be solution(time) = true;
    For time = "25:51", the output should be solution(time) = false;
    For time = "02:76", the output should be solution(time) = false.

    A string representing time in HH:MM format. It is guaranteed that the first
    two characters, as well as the last two characters, are digits.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    
*/

bool solution(string time)
{
    // https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
    var format = "HH:mm";
    DateTime result;

    return DateTime.TryParseExact(time,
        format,
        CultureInfo.InvariantCulture,
        DateTimeStyles.None,
        out result);
}
