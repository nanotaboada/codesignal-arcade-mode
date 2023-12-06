/*  
    Problem
    --------------------------------------------------------------------------------
    Given the string, check if it is a palindrome.

    - For inputString = "aabaa", the output should be solution(inputString) = true.
    - For inputString = "abac", the output should be solution(inputString) = false.
    - For inputString = "a", the output should be solution(inputString) = true.

    Guaranteed constraints:
    1 ≤ inputString.length ≤ 105.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    A "palindrome" is a word, phrase, or sequence that reads the same backwards
    as forwards (e.g. madam or nurses run).
    A way to solve the problem would be to literally reverse the provided text.
*/

bool solution(string inputString)
{
    var forwards = inputString.ToLower().Replace(" ", "");
    var backwards = new string(forwards.ToCharArray().Reverse().ToArray());
    
    return forwards == backwards;
}
