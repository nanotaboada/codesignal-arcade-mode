/*  
    Problem
    --------------------------------------------------------------------------------
    Given an array of integers, replace all the occurrences of elemToReplace
    with substitutionElem.
    
    Example
    
    For inputArray = [1, 2, 1], elemToReplace = 1, and substitutionElem = 3,
    the output should be
    solution(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

int[] solution(int[] inputArray, int elemToReplace, int substitutionElem)
{
    return inputArray
        .Select(elem => elem == elemToReplace ? substitutionElem : elem)
        .ToArray(); 
}
