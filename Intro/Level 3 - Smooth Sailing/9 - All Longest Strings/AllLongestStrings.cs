/*  
    Problem
    --------------------------------------------------------------------------------
    Given an array of strings, return another array containing all of its longest
    strings.
    
    Example
    
    For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
    solution(inputArray) = ["aba", "vcd", "aba"].

    Guaranteed constraints:
    1 ≤ inputArray.length ≤ 10,
    1 ≤ inputArray[i].length ≤ 10.
*/


/*  
    Solution
    --------------------------------------------------------------------------------
*/

string[] solution(string[] inputArray)
{
    // Find the longest possible length
    var longest = inputArray
        .Aggregate(String.Empty, (longest, current) => longest.Length > current.Length ? longest : current)
        .Length;
    
    // Return elements with the longest length
    return inputArray
        .Where(element => element.Length == longest)
        .ToArray();
}
