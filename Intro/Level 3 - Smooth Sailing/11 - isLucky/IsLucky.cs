/*  
    Problem
    --------------------------------------------------------------------------------
    Ticket numbers usually consist of an even number of digits. A ticket number
    is considered lucky if the sum of the first half of the digits is equal to
    the sum of the second half.
    
    Given a ticket number n, determine if it's lucky or not.
    
    Example
    
    For n = 1230, the output should be solution(n) = true.
    For n = 239017, the output should be solution(n) = false.

    Guaranteed constraints:
    10 ≤ n < 106.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

bool solution(int n)
{
    var ticket = n.ToString();
    var half = ticket.Length / 2;

    var firstHalfSum = ticket
        .Take(half)
        .Select(character => Char.GetNumericValue(character))
        .Sum();

    var secondHalfSum = ticket
        .Skip(half)
        .Select(character => Char.GetNumericValue(character))
        .Sum();
    
    return firstHalfSum == secondHalfSum;
}
