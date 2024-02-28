/*  
    Problem
    --------------------------------------------------------------------------------
    Sudoku is a number-placement puzzle. The objective is to fill a 9 × 9 grid
    with digits so that each column, each row, and each of the nine 3 × 3
    sub-grids that compose the grid contains all of the digits from 1 to 9.
    
    This algorithm should check if the given grid of numbers represents a
    correct solution to Sudoku.
    
    Example

    For grid = [
        [1, 3, 2, 5, 4, 6, 9, 8, 7],
        [4, 6, 5, 8, 7, 9, 3, 2, 1],
        [7, 9, 8, 2, 1, 3, 6, 5, 4],
        [9, 2, 1, 4, 3, 5, 8, 7, 6],
        [3, 5, 4, 7, 6, 8, 2, 1, 9],
        [6, 8, 7, 1, 9, 2, 5, 4, 3],
        [5, 7, 6, 9, 8, 1, 4, 3, 2],
        [2, 4, 3, 6, 5, 7, 1, 9, 8],
        [8, 1, 9, 3, 2, 4, 7, 6, 5]
    ]

    the output should be solution(grid) = true;

    For grid = [
        [1, 3, 4, 2, 5, 6, 9, 8, 7],
        [4, 6, 8, 5, 7, 9, 3, 2, 1],
        [7, 9, 2, 8, 1, 3, 6, 5, 4],
        [9, 2, 3, 1, 4, 5, 8, 7, 6],
        [3, 5, 7, 4, 6, 8, 2, 1, 9],
        [6, 8, 1, 7, 9, 2, 5, 4, 3],
        [5, 7, 6, 9, 8, 1, 4, 3, 2],
        [2, 4, 5, 6, 3, 7, 1, 9, 8],
        [8, 1, 9, 3, 2, 4, 7, 6, 5]
    ]

    the output should be solution(grid) = false.

    The output should be false: each of the nine 3 × 3 sub-grids should contain
    all of the digits from 1 to 9.

    Guaranteed constraints:
    grid.length = 9,
    grid[i].length = 9,
    1 ≤ grid[i][j] ≤ 9.
*/

/*  
    Solution
    --------------------------------------------------------------------------------

*/

bool solution(int[][] grid)
{
    for (var index = 0; index < 9; index++)
    {
        if (!IsValidRow(grid, index)
            || !IsValidColumn(grid, index))
            {
                return false;
            }
    }

    for (var startRow = 0; startRow < 9; startRow += 3)
    {
        for (int startColumn = 0; startColumn < 9; startColumn += 3)
        {
            if (!IsValidBox(grid, startRow, startColumn))
            {
                return false;
            }
        }
    }

    return true;
}

private static bool IsValidRow(int[][] grid, int row)
{
    var seen = new bool[10];

    foreach (var number in grid[row])
    {
        if (number != 0)
        {
            if (seen[number])
            {
                return false;
            }

            seen[number] = true;
        }
    }

    return true;
}

private static bool IsValidColumn(int[][] grid, int column)
{
    var seen = new bool[10];

    for (var index = 0; index < 9; index++)
    {
        var row = grid[index];

        if (row.Length <= column)
        {
            continue;
        }

        var number = row[column];

        if (number != 0)
        {
            if (seen[number])
            {
                return false;
            }

            seen[number] = true;
        }
    }

    return true;
}

private static bool IsValidBox(int[][] grid, int startRow, int startColumn)
{
    var seen = new bool[10];

    for (var row = 0; row < 3; row++)
    {
        for (var column = 0; column < 3; column++)
        {
            var currentRow = grid[row + startRow];

            if (currentRow.Length <= column + startColumn)
            {
                continue;
            }

            var number = currentRow[column + startColumn];

            if (number != 0)
            {
                if (seen[number])
                {
                    return false;
                }

                seen[number] = true;
            }
        }
    }

    return true;
}
