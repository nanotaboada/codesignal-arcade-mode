/*  
    Problem
    --------------------------------------------------------------------------------
    A string is said to be beautiful if each letter in the string appears at
    most as many times as the previous letter in the alphabet within the
    string; ie: 'b' occurs no more times than 'a'; 'c' occurs no more times than
    'b'; etc. Note that letter 'a' has no previous letter.
    
    Given a string, check whether it is beautiful.
    
    Example
    
    For inputString = "bbbaacdafe", the output should be
    solution(inputString) = true.
    
    This string contains 3 'a's, 3 'b's, 1 'c', 1 'd', 1 'e', and 1 'f'
    (and 0 of every other letter), so since there aren't any letters that appear
    more frequently than the previous letter, this string qualifies as beautiful.
    
    For inputString = "aabbb", the output should be
    solution(inputString) = false.
    
    Since there are more 'b's than 'a's, this string is not beautiful.
    
    For inputString = "bbc", the output should be solution(inputString) = false.

    Although there are more 'b's than 'c's, this string is not beautiful because
    there are no 'a's, so therefore there are more 'b's than 'a's.

    Guaranteed constraints:
    3 ≤ inputString.length ≤ 50.
*/


/*  
    Solution
    --------------------------------------------------------------------------------
*/

bool solution(string inputString)
{
    var alphabet = "abcdefghijklmnopqrstuvwxyz";

    // Group letters and count their occurrences
    var occurrences = inputString
        .OrderBy(letter => letter) // Alphabetical order
        .GroupBy(letter => letter)
        .ToDictionary(group => group.Key, group => group.Count());

        // Iterate over the letters of the alphabet from 'b' to 'z' (inclusive).
        for (var index = 1; index < alphabet.Length; index++)
        {
            var letter = alphabet[index];
            var previousLetter = alphabet[index - 1];
            var occurrence = occurrences.ContainsKey(letter)
                ? occurrences[letter]
                : 0;
            var previousOccurrence = occurrences.ContainsKey(previousLetter)
                ? occurrences[previousLetter]
                : 0;

            if (occurrence > previousOccurrence)
            {
                return false;
            }
        }

        return true;
}
