/*  
    Problem
    --------------------------------------------------------------------------------
    Given two strings, find the number of common characters between them.
    
    Example
    
    For s1 = "aabcc" and s2 = "adcaa", the output should be solution(s1, s2) = 3.
    Strings have 3 common characters - 2 "a"s and 1 "c".

    Guaranteed constraints:
    1 ≤ s1.length < 15.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    This problem could be easily addressed with .Distinct() and .Intersect()
    *but* the confusing detail with the example is that, as it can be seen,
    the pair of "a" is somehow considered a common character.

    Then we will simply:
    - Loop through each character in s1.
    - If there are matching characters in s2, count and remove one match.

    -------------    -------------    -------------    -------------    -------------
    | s1  | s2  |    | s1  | s2  |    | s1  | s2  |    | s1  | s2  |    | s1  | s2  |
    -------------    -------------    -------------    -------------    -------------
   >|  a  |  a  |<   |     |     |    |     |     |    |     |     |    |     |     |  
    |     |  d  |   >|  a  |  d  |    |     |  d  |    |     |  d  |    |     |  d  |
    |     |  c  |    |     |  c  |    |  b  |  c  |    |     |  c  |<   |     |     |
    |     |  a  |    |     |  a  |<   |     |     |   >|  c  |     |    |     |     |
    |     |  a  |    |     |  a  |    |     |  a  |    |     |  a  |    |  c  |  a  |
    -------------    -------------    -------------    -------------    -------------
      count = 1        count = 2        count = 2        count = 3        count = 3

*/

int solution(string s1, string s2)
{
    var first = s1.ToList();
    var second = s2.ToList();
    var count = 0;

    foreach (var character in first)
    {
        if (second.Contains(character))
        {
            second.Remove(character);
            count++;
        }
    }
    
    return count;
}