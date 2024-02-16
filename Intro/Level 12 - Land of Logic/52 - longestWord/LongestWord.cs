/*  
    Problem
    --------------------------------------------------------------------------------
    Define a word as a sequence of consecutive English letters. Find the longest
    word from the given string.
    
    Example
    
    For text = "Ready, steady, go!",
    the output should be solution(text) = "steady".

    Guaranteed constraints:
    4 ≤ text.length ≤ 50.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    
*/

string solution(string text)
{
    // https://regex101.com/r/GVFqI4/1
    var pattern = @"[^a-zA-Z]+";

    var longest = Regex.Split(text, pattern)
        .OrderByDescending(word => word.Length)
        .First();

    return longest;
}
