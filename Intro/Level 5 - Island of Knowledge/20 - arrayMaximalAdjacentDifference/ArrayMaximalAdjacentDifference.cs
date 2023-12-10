/*  
    Problem
    --------------------------------------------------------------------------------
    Given an array of integers, find the maximal absolute difference between
    any two of its adjacent elements.
    
    Example
    
    For inputArray = [2, 4, 1, 0], the output should be
    solution(inputArray) = 3.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

int solution(int[] inputArray)
{
    var maximalAbsoluteDifference = 0;

    for (var i = 0; i < inputArray.Length-1; i++)
    {
        var absoluteDifference = Math.Abs(inputArray[i] - inputArray[i+1]);

        if (absoluteDifference > maximalAbsoluteDifference)
        {
            maximalAbsoluteDifference = absoluteDifference;
        }
    }
    
    return maximalAbsoluteDifference;
}