/*  
    Problem
    --------------------------------------------------------------------------------
    Find the leftmost digit that occurs in a given string.
    
    Example
    
    For inputString = "var_1__Int", the output should be
    solution(inputString) = '1';
    
    For inputString = "q2q-q", the output should be
    solution(inputString) = '2';
    
    For inputString = "0ss", the output should be
    solution(inputString) = '0'.

    Guaranteed constraints:
    3 ≤ inputString.length ≤ 10.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

char solution(string inputString)
{
    return inputString
        .First(character => char.IsDigit(character));
}
