/*  
    Problem
    --------------------------------------------------------------------------------
    Given the positions of a white bishop and a black pawn on the standard
    chess board, determine whether the bishop can capture the pawn in one move.

    The bishop has no restrictions in distance for each move, but is limited to
    diagonal movement. Check out the example below to see how it can move:

    +---+---+---+---+---+---+---+---+
    |   |   |   |   |   |   |   | / | 8
    |---|---|---|---|---|---|---|---|
    | \ |   |   |   |   |   | / |   | 7
    |---|---|---|---|---|---|---|---|
    |   | \ |   |   |   | / |   |   | 6
    |---|---|---|---|---|---|---|---|
    |   |   | \ |   | / |   |   |   | 5
    |---|---|---|---|---|---|---|---|
    |   |   |   | X |   |   |   |   | 4
    |---|---|---|---|---|---|---|---|
    |   |   | / |   | \ |   |   |   | 3
    |---|---|---|---|---|---|---|---|
    |   | / |   |   |   | \ |   |   | 2
    |---|---|---|---|---|---|---|---|
    | / |   |   |   |   |   | \ |   | 1
    +---+---+---+---+---+---+---+---+
      A   B   C   D   E   F   G   H

    Example
    
    For bishop = "a1" and pawn = "c3", the output should be
    solution(bishop, pawn) = true.

    +---+---+---+---+---+---+---+---+
    |   |   |   |   |   |   |   | / | 8
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   | / |   | 7
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   | / |   |   | 6
    |---|---|---|---|---|---|---|---|
    |   |   |   |   | / |   |   |   | 5
    |---|---|---|---|---|---|---|---|
    |   |   |   | / |   |   |   |   | 4
    |---|---|---|---|---|---|---|---|
    |   |   | X |   |   |   |   |   | 3
    |---|---|---|---|---|---|---|---|
    |   | / |   |   |   |   |   |   | 2
    |---|---|---|---|---|---|---|---|
    | X |   |   |   |   |   |   |   | 1
    +---+---+---+---+---+---+---+---+
      A   B   C   D   E   F   G   H

    For bishop = "h1" and pawn = "h3", the output should be
    solution(bishop, pawn) = false.

    +---+---+---+---+---+---+---+---+
    | \ |   |   |   |   |   |   |   | 8
    |---|---|---|---|---|---|---|---|
    |   | \ |   |   |   |   |   |   | 7
    |---|---|---|---|---|---|---|---|
    |   |   | \ |   |   |   |   |   | 6
    |---|---|---|---|---|---|---|---|
    |   |   |   | \ |   |   |   |   | 5
    |---|---|---|---|---|---|---|---|
    |   |   |   |   | \ |   |   |   | 4
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   | \ |   | X | 3
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   | \ |   | 2
    |---|---|---|---|---|---|---|---|
    |   |   |   |   |   |   |   | X | 1
    +---+---+---+---+---+---+---+---+
      A   B   C   D   E   F   G   H

    Guaranteed constraints:
    bishop.length = 2,
    'a' ≤ bishop[0] ≤ 'h',
    1 ≤ bishop[1] ≤ 8,
    pawn.length = 2,
    'a' ≤ pawn[0] ≤ 'h',
    1 ≤ pawn[1] ≤ 8.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    Each square on the chessboard can be identified by its coordinates, where
    the file (column) is represented by a letter (A to H), and the rank (row)
    is represented by a number (1 to 8).
    
    For example, the square A1 has coordinates (File: A, Rank: 1), and the
    square E5 has coordinates (File: E, Rank: 5).

                   file               
      +---+---+---+---+---+---+---+---+
      |   |   |   |   |   |   |   | l | 8
      |---|---|---|---|---|---|---|---|
      |   |   |   |   |   |   | a |   | 7
      |---|---|---|---|---|---|---|---|
      |   |   |   |   |   | n |   |   | 6
    r |---|---|---|---|---|---|---|---|
    a |   |   |   |   | o |   |   |   | 5
    n |---|---|---|---|---|---|---|---|
    k |   |   |   | g |   |   |   |   | 4
      |---|---|---|---|---|---|---|---|
      |   |   | a |   |   |   |   |   | 3
      |---|---|---|---|---|---|---|---|
      |   | i |   |   |   |   |   |   | 2
      |---|---|---|---|---|---|---|---|
      | d |   |   |   |   |   |   |   | 1
      +---+---+---+---+---+---+---+---+
        A   B   C   D   E   F   G   H

    A diagonal is a set of squares that share the same color and are connected
    diagonally across the chessboard.
    
    Diagonals can run from one corner of the board to the opposite corner, and
    there are two types of diagonals: those with increasing rank and file
    indices and those with decreasing rank and file indices.

    Consider two squares (File1, Rank1) and (File2, Rank2) on the same diagonal.
    For any pair of squares on the same diagonal, the absolute file difference
    |File1 - File2| will be equal to the absolute rank difference |Rank1 - Rank2|.
    
    This is a property of diagonals in a grid, and it holds true for both
    diagonals with increasing and decreasing indices.

    Exmple: A5 and C3

                   file               
     +---+---+---+---+---+---+---+---+
     |   |   |   |   |   |   |   |   | 8
     |---|---|---|---|---|---|---|---|
     |   |   |   |   |   |   |   |   | 7
     |---|---|---|---|---|---|---|---|
     |   |   |   |   |   |   |   |   | 6
   r |---|---|---|---|---|---|---|---|
   a | X |   |   |   |   |   |   |   | 5
   n |---|---|---|---|---|---|---|---|
   k |   | \ |   |   |   |   |   |   | 4
     |---|---|---|---|---|---|---|---|
     |   |   | X |   |   |   |   |   | 3
     |---|---|---|---|---|---|---|---|
     |   |   |   | \ |   |   |   |   | 2
     |---|---|---|---|---|---|---|---|
     |   |   |   |   | \ |   |   |   | 1
     +---+---+---+---+---+---+---+---+
       A   B   C   D   E   F   G   H

    ------------------------
    | Square | File | Rank |
    ------------------------
    |   A5   |   1  |  5   |
    |   C3   |   3  |  3   |
    ------------------------
    |  Diff  |   2  |  2   |
    ------------------------

*/

bool solution(string bishop, string pawn)
{
        var bishopFile = bishop[0] - 'a';
        var bishopRank = bishop[1] - '1';
        var pawnFile = pawn[0] - 'a';
        var pawnRank = pawn[1] - '1';

        return Math.Abs(bishopFile - pawnFile) == Math.Abs(bishopRank - pawnRank);
}
