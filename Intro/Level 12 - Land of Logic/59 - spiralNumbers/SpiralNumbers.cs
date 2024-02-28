/*  
    Problem
    --------------------------------------------------------------------------------
    Construct a square matrix with a size N × N containing integers from 1 to
    N * N in a spiral order, starting from top-left and in clockwise direction.
    
    Example
    
    For n = 3, the output should be

    solution(n) = [
        [1, 2, 3],
        [8, 9, 4],
        [7, 6, 5]
    ]

    Guaranteed constraints:
    3 ≤ n ≤ 100.
*/

/*  
    Solution
    --------------------------------------------------------------------------------

      -------->  
    ^ [n, n, n] |
    | [n, n, n] |
    | [n, n, n] v
      <--------
*/

int[][] solution(int n)
{
    var matrix = new int[n][];
    
    // Initialize each row of the matrix with a new integer array of size n
    for (var index = 0; index < n; index++)
    {
        matrix[index] = new int[n];
    }
    
    var number = 1;

    var topRow = 0;
    var bottomRow = n - 1;
    var leftColumn = 0;
    var rightColumn = n - 1;
    
    // Fill the matrix with numbers in a clockwise spiral order
    while (number <= n * n)
    {
        // Traverse the top row from left to right
        for (var index = leftColumn; index <= rightColumn; index++)
        {
            matrix[topRow][index] = number++;
        }

        topRow++;
        
        // Traverse the right column from top to bottom
        for (var index = topRow; index <= bottomRow; index++)
        {
            matrix[index][rightColumn] = number++;
        }

        rightColumn--;
        
        // Traverse the bottom row from right to left
        for (var index = rightColumn; index >= leftColumn; index--)
        {
            matrix[bottomRow][index] = number++;
        }

        bottomRow--;
        
        // Traverse the left column from bottom to top
        for (int index = bottomRow; index >= topRow; index--)
        {
            matrix[index][leftColumn] = number++;
        }

        leftColumn++;
    }
    
    return matrix;
}
