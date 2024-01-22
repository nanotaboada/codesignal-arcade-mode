/*  
    Problem
    --------------------------------------------------------------------------------
    Given a string, find out if its characters can be rearranged to form a
    palindrome.
    
    Example
    
    For inputString = "aabb", the output should be
    solution(inputString) = true.
    
    We can rearrange "aabb" to make "abba", which is a palindrome.

    Guaranteed constraints:
    1 ≤ inputString.length ≤ 50.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    Rules for even-length palindrome:
    
    Every character in the given set must have an even count. This ensures that
    the characters can be symmetrically arranged around the center of the
    palindrome.
    
    For example, in the string "aabbcc", 'a' appears twice, 'b' appears twice,
    and 'c' appears twice. All characters have an even count, making it possible
    to create a palindrome.

    Rules for odd-length palindrome:
    
    Only one character in the given set can have an odd count, while all other
    characters must have an even count. This is because the middle character of
    an odd-length palindrome does not need a symmetric counterpart.
    
    For example, in the string "abcba", 'a' appears twice, 'b' appears twice,
    and 'c' appears once. All characters, except 'c', have an even count, and
    'c' is the middle character.
*/

bool solution(string inputString)
{
    var canBeRearranged = false;

    var groupOfCharacters = inputString
        .GroupBy(character => character);

    // Even-length
    if (inputString.Length % 2 == 0)
    {
        // Every character in the sequence must have an even count.
        canBeRearranged = groupOfCharacters
            .All(group => group.Count() % 2 == 0);
    }
    // Odd-length
    else
    {
        // Only one character in the sequence can have an odd count.
        canBeRearranged = groupOfCharacters
            .Where(group => group.Count() % 2 != 0)
            .Count() == 1;
    }
    
    return canBeRearranged;
}
