/*  
    Problem
    --------------------------------------------------------------------------------
    In the popular Minesweeper game you have a board with some mines and those
    cells that don't contain a mine have a number in it that indicates the total
    number of mines in the neighboring cells. Starting off with some arrangement
    of mines we want to create a Minesweeper game setup.
    
    Example
    
    For matrix =
        [
            [true, false, false],
            [false, true, false],
            [false, false, false]
        ]

    the output should be
    solution(matrix) =
        [
            [1, 2, 1],
            [2, 1, 1],
            [1, 1, 1]
        ]

    Guaranteed constraints:
    2 ≤ matrix.length ≤ 100,
    2 ≤ matrix[0].length ≤ 100.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    To better illustrate the concept of neighboring cells, let's use the analogy
    of cardinal points:
    
    ----------------------------------------------
    | Cardinal points  | Offsets (x, y)          |
    ----------------------------------------------
    |  NW    N    NE   | (-1,-1) (-1, 0) (-1,+1) |
    |    \   |   /     |                         |
    |     \  |  /      |                         |
    |  W --  ?  -- E   | ( 0,-1) ( 0, 0) ( 0,+1) |
    |      / |  \      |                         |
    |     /  |   \     |                         |
    |  SW    S    SE   | (+1,-1) (+1, 0) (+1,+1) |
    ----------------------------------------------

    --------------------------------------
    | Cardinal points  | Offsets [x, y]  |
    --------------------------------------
    | North West       | x = -1, y = -1  |
    | North            | x = -1, y =  0  |
    | North East       | x = -1, y =  1  |
    | West             | x =  0, y = -1  |
    | East             | x =  0, y =  1  |
    | South West       | x = 1,  y = -1  |
    | South            | x = 1,  y = 0   |
    | South East       | x = 1,  y = 1   |
    --------------------------------------
*/

int[][] solution(bool[][] matrix)
{
    var rows = matrix.Length;
    var columns = matrix[0].Length;
    var board = new int[rows][];
    
    for (var row = 0; row < rows; row++)
    {
        board[row] = new int[columns];

        for (var column = 0; column < columns; column++)
        {
            board[row][column] = GetNeighboringMines(matrix, row, column);
        }
    }

    return board;
}

static int GetNeighboringMines(bool[][] matrix, int row, int column)
{
    var mines = 0;

    var xOffsets = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
    var yOffsets = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

    // Scan for all 8 cardinal points
    for (var cell = 0; cell < 8; cell++)
    {
        var x = row + xOffsets[cell];
        var y = column + yOffsets[cell];

        if (x >= 0 && x < matrix.Length
            && y >= 0 && y < matrix[0].Length
            && matrix[x][y]) // matrix[x][y] == "true"
        {
            mines++;
        }
    }

    return mines;
}