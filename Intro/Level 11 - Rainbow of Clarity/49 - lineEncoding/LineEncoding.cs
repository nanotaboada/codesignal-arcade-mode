/*  
    Problem
    --------------------------------------------------------------------------------
    Given a string, return its encoding defined as follows:
    
    First, the string is divided into the least possible number of disjoint
    substrings consisting of identical characters, for example:
    "aabbbc" is divided into ["aa", "bbb", "c"]

    Next, each substring with length greater than one is replaced with a
    concatenation of its length and the repeating character, for example:
    substring "bbb" is replaced by "3b"

    Finally, all the new strings are concatenated together in the same order
    and a new string is returned.

    Example

    For s = "aabbbc", the output should be
    solution(s) = "2a3bc".

    Guaranteed constraints:
    4 ≤ s.length ≤ 15.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    
*/

string solution(string s)
{
    var encoding = new StringBuilder();
    var count = 1;

    for (var index = 1; index <= s.Length; index++)
    {
        // Check if the current character is the last character,
        // or if it's different from the previous one
        if (index == s.Length || s[index] != s[index - 1])
        {
            // If there is more than one consecutive character,
            if (count > 1)
            {
                // append the count
                encoding.Append(count);
            }
            // Append the current character to the encoding
            encoding.Append(s[index - 1]);
            // Reset the count for the next character
            count = 1;
        }
        else
        {
            // Increment the count of consecutive characters
            count++;
        }
    }

    return encoding.ToString();
}
