/*  
    Problem
    --------------------------------------------------------------------------------
    You are given an array of integers representing coordinates of obstacles
    situated on a straight line.
    
    Assume that you are jumping from the point with coordinate 0 to the right.
    You are allowed only to make jumps of the same length represented by some
    integer.
    
    Find the minimal length of the jump enough to avoid all the obstacles.
    
    Example
    
    For inputArray = [5, 3, 6, 7, 9], the output should be
    solution(inputArray) = 4.
    
    Check out the image below for better understanding:

              jump = 4
         /-----------------\ /-----------------\ /-------------                  
        |              X    |    X    X    X    |    X
    ----|----|----|----|----|----|----|----|----|----|----|----
        0    1    2    3    4    5    6    7    8    9    10

    Guaranteed constraints:
    2 ≤ inputArray.length ≤ 1000,
    1 ≤ inputArray[i] ≤ 1000.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

int solution(int[] inputArray)
{
    Array.Sort(inputArray);

    var minimalLength = 1;

    // The modulus operation checks if the obstacle's point is divisible by
    // the current jump length. If any obstacle is found at a point
    // divisible by the jump length, the current jump length is invalid.
    while (inputArray.Any(obstacle => obstacle % minimalLength == 0))
    {
        // Continue increasing the minimum jump length until a valid length
        // is found.
        minimalLength++;
    }

    return minimalLength;
}
