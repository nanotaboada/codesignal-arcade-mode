/*  
    Problem
    --------------------------------------------------------------------------------
    Given a string, find the shortest possible string which can be achieved by
    adding characters to the end of initial string to make it a palindrome.
    
    Example
    
    For st = "abcdc", the output should be
    solution(st) = "abcdcba".

    Guaranteed constraints:
    3 ≤ st.length ≤ 10.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    Despite that it's not explicitly indicated in the guaranteed constraints,
    the input string 'st' contains only lowercase English characters, therefore
    there is no need to check for digits, punctuation or whitespace characters.

    Given that there is no way to detect the pivot character, and the palindrome
    needs to literally be built, we will take the following approach:
*/

string solution(string st)
{
    var palindrome = new StringBuilder();
    palindrome.Append(st);
    var count = 0;

    // While the provided sequence is not a palindrome
    while(!IsPalindrome(palindrome.ToString()))
    {
        // Remove the previous sub-sequence candidate
        // (on the first attempt it won't have any effect)
        palindrome.Remove(st.Length, count);
        // (starting with one element)
        count++;
        // Take a new sub-sequence from the beginning, reverse the sub-sequence
        // and append it to the original
        palindrome.Append(st.Take(count).Reverse().ToArray());
    }

    return palindrome.ToString();
}

static bool IsPalindrome(string word)
{
    return new string(word.ToCharArray().Reverse().ToArray()) == word;
}
