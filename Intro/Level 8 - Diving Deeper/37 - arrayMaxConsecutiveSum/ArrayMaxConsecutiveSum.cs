/*  
    Problem
    --------------------------------------------------------------------------------
    Given array of integers, find the maximal possible sum of some of its k
    consecutive elements.
    
    Example
    
    For inputArray = [2, 3, 5, 1, 6] and k = 2, the output should be
    solution(inputArray, k) = 8.
    
    All possible sums of 2 consecutive elements are:
    
    2 + 3 = 5;
    3 + 5 = 8;
    5 + 1 = 6;
    1 + 6 = 7.
    
    Thus, the answer is 8.

    Guaranteed constraints:
    3 ≤ inputArray.length ≤ 105,
    1 ≤ inputArray[i] ≤ 1000.
    1 ≤ k ≤ inputArray.length.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    Sliding Window technique

    |   k   | ---------->

    Given inputArray = [2, 3, 5, 1, 6] and k = 2

    | 2 | 3 | 5 | 1 | 6 |

    | 2 + 3 | -----------

    | 2 | 3 | 5 | 1 | 6 |
      -       +
    --> | 3 + 5 | -------

    | 2 | 3 | 5 | 1 | 6 |
          -       +
    ------> | 5 + 1 | ---

    | 2 | 3 | 5 | 1 | 6 |
              -       +
    ----------> | 1 + 6 |

*/

int solution(int[] inputArray, int k)
{   
    // Init the maximal possible sum with the minimum possible value
    // (for the first Math.Max to make sense)
    var max = int.MinValue;
    
    // Sliding Window
    var start = 0;
    var end = k;
    var sum = 0;  

    // Sum of initial window position
    for (var index = 0; index < end; index++)
    {
        sum += inputArray[index];
    }
    
    // Update max sum
    max = sum;

    // Cycle until the end of the window meets the end of the collection
    while(end < inputArray.Length)
    {
        // Remove element behind
        sum -= inputArray[start];
        // Slide the start of the window
        start++;

        // Add element in front
        sum += inputArray[end];
        // Slide the end of the window
        end++;
        
        max = Math.Max(sum, max);
    }
    
    return max;
}
