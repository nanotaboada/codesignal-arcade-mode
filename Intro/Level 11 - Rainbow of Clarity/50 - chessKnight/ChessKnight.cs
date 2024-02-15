/*  
    Problem
    --------------------------------------------------------------------------------
    Given a position of a knight on the standard chessboard, find the number of
    different moves the knight can perform.

    The knight can move to a square that is two squares horizontally and one
    square vertically, or two squares vertically and one square horizontally
    away from it. The complete move therefore looks like the letter L.
    
    Check out the image below to see all valid moves for a knight piece that is
    placed on one of the central squares.

    +---+---+---+---+---+---+---+---+
    |   |   |   |   |   |   |   |   | 8
    |---|---|---|---|---|---|---|---|
    |   |   | ? |   | ? |   |   |   | 7
    |---|---|---|---|---|---|---|---|
    |   | ? |   |   |   | ? |   |   | 6
    |---|---|---|---|---|---|---|---|
    |   |   |   | X |   |   |   |   | 5
    |---|---|---|---|---|---|---|---|
    |   | ? |   |   |   | ? |   |   | 4
    |---|---|---|---|---|---|---|---|
    |   |   | ? |   | ? |   |   |   | 3
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 2
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 1
    +---+---+---+---+---+---+---+---+
      A   B   C   D   E   F   G   H

    Example
    
    For cell = "a1", the output should be solution(cell) = 2.

    +---+---+---+---+---+---+---+---+
    |   |   |   |   |   |   |   |   | 8
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 7
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 6
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 5
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 4
    |---|---|---|---|---|---|---|---|
    |   | ? |   |   |   |   |   |   | 3
    |---|---|---|---|---|---|---|---|
    |   |   | ? |   |   |   |   |   | 2
    |---|---|---|---|---|---|---|---|
    | X |   |   |   |   |   |   |   | 1
    +---+---+---+---+---+---+---+---+
      A   B   C   D   E   F   G   H

    For cell = "c2", the output should be solution(cell) = 6.

    +---+---+---+---+---+---+---+---+
    |   |   |   |   |   |   |   |   | 8
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 7
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 6
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   |   | 5
    |---|---|---|---|---|---|---|---|
    |   | ? |   | ? |   |   |   |   | 4
    |---|---|---|---|---|---|---|---|
    | ? |   |   |   | ? |   |   |   | 3
    |---|---|---|---|---|---|---|---|
    |   |   | X |   |   |   |   |   | 2
    |---|---|---|---|---|---|---|---|
    | ? |   |   |   | ? |   |   |   | 1
    +---+---+---+---+---+---+---+---+
      A   B   C   D   E   F   G   H

    Guaranteed constraints:
    cell.length = 2,
    'a' ≤ cell[0] ≤ 'h',
    1 ≤ cell[1] ≤ 8.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    
*/

int solution(string cell)
{
    var possibleMoves = 0;

    // By subtracting 'a' from the file character, we get the offset
    // from 'a' in the ASCII table.
    var file = cell[0] - 'a' + 1;
    var rank = int.Parse(cell[1].ToString());

    // Define every possible move for a knight
    int[][] moves = new int[][]
    {
        new int[] { 2, 1 },
        new int[] { 1, 2 },
        new int[] { -1, 2 },
        new int[] { -2, 1 },
        new int[] { -2, -1 },
        new int[] { -1, -2 },
        new int[] { 1, -2 },
        new int[] { 2, -1 }
    };

    // Check if each possible move is within the board
    foreach (var move in moves)
    {
        var fileMove = file + move[0];
        var rankMove = rank + move[1];

        if (fileMove >= 1 
            && fileMove <= 8
            && rankMove >= 1 
            && rankMove <= 8)
        {
            possibleMoves++;
        }
    }

    return possibleMoves;
}
