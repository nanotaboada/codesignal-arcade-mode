/*  
    Problem
    --------------------------------------------------------------------------------
    Given a string, output its longest prefix which contains only digits.
    
    Example
    
    For inputString = "123aa1", the output should be
    solution(inputString) = "123".

    Guaranteed constraints:
    3 ≤ inputString.length ≤ 100.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

string solution(string inputString)
{
    var prefix = inputString
        .TakeWhile(character => char.IsDigit(character))
        .ToArray();
        
    return new string(prefix);
}
