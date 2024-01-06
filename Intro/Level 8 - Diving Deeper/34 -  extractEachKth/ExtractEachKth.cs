/*  
    Problem
    --------------------------------------------------------------------------------
    Given array of integers, remove each kth element from it.
    
    Example
    
    For inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] and k = 3, the output should be
    solution(inputArray, k) = [1, 2, 4, 5, 7, 8, 10].

    Guaranteed constraints:
    5 ≤ inputArray.length ≤ 15,
    -20 ≤ inputArray[i] ≤ 20.
    1 ≤ k ≤ 10.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

int[] solution(int[] inputArray, int k)
{
    return inputArray
        .Where((element, index) => (index + 1) % k != 0)
        .ToArray();
}