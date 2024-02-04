/*  
    Problem
    --------------------------------------------------------------------------------
    Determine if the given character is a digit or not.
    
    Example
    
    For symbol = '0', the output should be
    solution(symbol) = true;

    For symbol = '-', the output should be
    solution(symbol) = false.

    Guaranteed constraints:
    Given symbol is from ASCII table.
*/

/*  
    Solution
    --------------------------------------------------------------------------------

*/

bool solution(char symbol)
{
    return char.IsDigit(symbol);
}
