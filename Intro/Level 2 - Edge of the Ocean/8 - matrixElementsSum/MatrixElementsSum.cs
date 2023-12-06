/*  
    Problem
    --------------------------------------------------------------------------------
    After becoming famous, the CodeBots decided to move into a new building
    together. Each of the rooms has a different cost, and some of them are free,
    but there's a rumour that all the free rooms are haunted! Since the CodeBots
    are quite superstitious, they refuse to stay in any of the free rooms, or
    any of the rooms below any of the free rooms.

    Given matrix, a rectangular matrix of integers, where each value represents
    the cost of the room, your task is to return the total sum of all rooms that
    are suitable for the CodeBots (ie: add up all the values that don't appear
    below a 0).

    Example

    For

    matrix = [[0, 1, 1, 2], 
             [0, 5, 0, 0], 
             [2, 0, 3, 3]]

    the output should be solution(matrix) = 9

    Guaranteed constraints:
    1 ≤ matrix.length ≤ 5,
    1 ≤ matrix[i].length ≤ 5,
    0 ≤ matrix[i][j] ≤ 10.
*/

/*  
    Solution
    --------------------------------------------------------------------------------

*/

int solution(int[][] matrix)
{
    var sum = 0;
    var rows = matrix.Length;
    var columns = matrix[0].Length;

    // Loop through columns (left-to-right)
    for (var leftToRight = 0; leftToRight < columns; leftToRight++)
    {
        // Loop through rows (top-to-bottom)
        for (var topToBottom = 0; topToBottom < rows; topToBottom++)
        {
            if (matrix[topToBottom][leftToRight] == 0)
            {
                // When we find a zero we break the cycle, invalidating the
                // rest of the row
                break;
            }
            else
            {
                sum += matrix[topToBottom][leftToRight];
            }
        }
    }

    return sum;
}
