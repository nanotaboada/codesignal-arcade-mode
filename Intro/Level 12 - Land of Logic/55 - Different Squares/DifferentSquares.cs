/*  
    Problem
    --------------------------------------------------------------------------------
    Given a rectangular matrix containing only digits, calculate the number of
    different 2 × 2 squares in it.

    Example

    For matrix = [
        [1, 2, 1],
        [2, 2, 2],
        [2, 2, 2],
        [1, 2, 3],
        [2, 2, 1]
    ]

    the output should be solution(matrix) = 6.

    Here are all 6 different 2 × 2 squares:

    [1 2
    2 2]

    [2 1
    2 2]

    [2 2
    2 2]

    [2 2
    1 2]

    [2 2
    2 3]

    [2 3
    2 1]

    Guaranteed constraints:
    1 ≤ matrix.length ≤ 100,
    1 ≤ matrix[i].length ≤ 100,
    0 ≤ matrix[i][j] ≤ 9.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    
*/

int solution(int[][] matrix)
{
        var rows = matrix.Length;
        var columns = matrix[0].Length;
        // Collection to store the different (unique) 2 x 2 squares
        var squares = new HashSet<string>();

        for (var row = 0; row < rows - 1; row++)
        {
            for (var column = 0; column < columns - 1; column++)
            {
                var topLeft = matrix[row][column].ToString();
                var topRight = matrix[row][column + 1].ToString();
                var bottomLeft = matrix[row + 1][column].ToString();
                var bottomRight = matrix[row + 1][column + 1].ToString();

                var square = $"{topLeft}{topRight}{bottomLeft}{bottomRight}";
                squares.Add(square);
            }
        }

        return squares.Count;
}
