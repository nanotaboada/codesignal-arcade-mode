/*  
    Problem
    --------------------------------------------------------------------------------
    Correct variable names consist only of English letters, digits and
    underscores and they can't start with a digit.
    
    Check if the given string is a correct variable name.
    
    Example
    
    For name = "var_1__Int", the output should be
    solution(name) = true;
    
    For name = "qq-q", the output should be
    solution(name) = false;
    
    For name = "2w2", the output should be
    solution(name) = false.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

bool solution(string name)
{
    // https://regex101.com/r/cr8NGb/2
    const string pattern = "^[a-zA-Z_][a-zA-Z0-9_]*$";
    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
    
    return regex.IsMatch(name);
}
