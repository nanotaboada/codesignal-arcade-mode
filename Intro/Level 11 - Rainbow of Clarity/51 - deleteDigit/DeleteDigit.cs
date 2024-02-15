/*  
    Problem
    --------------------------------------------------------------------------------
    Given some integer, find the maximal number you can obtain by deleting
    exactly one digit of the given number.
    
    Example
    
    For n = 152, the output should be solution(n) = 52;
    For n = 1001, the output should be solution(n) = 101.

    Guaranteed constraints:
    10 ≤ n ≤ 106.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    
*/

int solution(int n)
{
    var integer = n.ToString();
    var maximal = 0;
    
    for (var index = 0; index < integer.Length; index++) 
    {
        var number = new StringBuilder(integer);
        number.Remove(index, 1);
        var obtained = int.Parse(number.ToString());
        maximal = Math.Max(maximal, obtained);
    }
    
    return maximal;
}
