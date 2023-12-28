/*  
    Problem
    --------------------------------------------------------------------------------
    Check if all digits of the given integer are even.
    
    Example
    
    For n = 248622, the output should be
    solution(n) = true;
    
    For n = 642386, the output should be
    solution(n) = false.

    Guaranteed constraints:
    1 ≤ n ≤ 109.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

bool solution(int n)
{
    return n
        .ToString()
        .Select(character => int.Parse(character.ToString()))
        .All(number => number % 2 == 0);
}
