/*  
    Problem
    --------------------------------------------------------------------------------
    You are given an array of integers. On each move you are allowed to increase
    exactly one of its element by one. Find the minimal number of moves required
    to obtain a strictly increasing sequence from the input.
    
    Example
    
    For inputArray = [1, 1, 1], the output should be
    solution(inputArray) = 3.

    Guaranteed constraints:
    3 ≤ inputArray.length ≤ 105,
    -105 ≤ inputArray[i] ≤ 105.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

int solution(int[] inputArray)
{
    var moves = 0;

    for (var i = 0; i < inputArray.Length -1; i++)
    {
        // Check if it is decreasing
        if (inputArray[i] >= inputArray[i+1])
        {
            var difference = inputArray[i] - inputArray[i+1];
            // Update the next element with the difference plus one to make it
            // increasing again
            inputArray[i+1] += difference + 1;
            // Accumulate the moves required to maintain the sequence strictly
            // increasing
            moves += difference + 1;
        }
    }

    return moves;
}
