/*  
    Problem
    --------------------------------------------------------------------------------
    Given a string, your task is to replace each of its characters by the next
    one in the English alphabet; i.e. replace a with b, replace b with c, etc
    (z would be replaced by a).
    
    Example
    For inputString = "crazy", the output should be
    solution(inputString) = "dsbaz".

    Guaranteed constraints:
    1 ≤ inputString.length ≤ 1000.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

string solution(string inputString)
{
    var shifted = new StringBuilder();
    
    foreach (var character in inputString)
    {
        if (character == 'z')
        {
            // (z would be replaced by a) 
            // because 'z' = 122, but 123 = '}'
            shifted.Append('a');
        }
        else
        {
            var ascii = (int)character;
            var letter = (char)(ascii + 1);
            shifted.Append(letter);
        }
    }
    
    return shifted.ToString();
}
