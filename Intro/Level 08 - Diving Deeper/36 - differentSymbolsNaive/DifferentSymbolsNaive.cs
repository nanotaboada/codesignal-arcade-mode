/*  
    Problem
    --------------------------------------------------------------------------------
    Given a string, find the number of different characters in it.
    
    Example
    
    For s = "cabca", the output should be
    solution(s) = 3.
    
    There are 3 different characters a, b and c.

    Guaranteed constraints:
    3 ≤ s.length ≤ 1000.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

int solution(string s)
{
    return s
        .Distinct()
        .Count();
}
