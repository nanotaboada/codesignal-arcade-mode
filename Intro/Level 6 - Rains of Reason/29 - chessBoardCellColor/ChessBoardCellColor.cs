/*  
    Problem
    --------------------------------------------------------------------------------
    Given two cells on the standard chess board, determine whether they have the
    same color or not.

      +---+---+---+---+---+---+---+---+
    8 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    7 |###|   |###|   |###|   |###|   |
      |---|---|---|---|---|---|---|---|
    6 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    5 |###|   |###|   |###|   |###|   |
      |---|---|---|---|---|---|---|---|
    4 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    3 |###|   |###|   |###|   |###|   |
      |---|---|---|---|---|---|---|---|
    2 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    1 |###|   |###|   |###|   |###|   |
      +---+---+---+---+---+---+---+---+
        A   B   C   F   E   F   G   H

    Example
    
    For cell1 = "A1" and cell2 = "C3", the output should be
    solution(cell1, cell2) = true.

      +---+---+---+---+---+---+---+---+
    8 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    7 |###|   |###|   |###|   |###|   |
      |---|---|---|---|---|---|---|---|
    6 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    5 |###|   |###|   |###|   |###|   |
      |---|---|---|---|---|---|---|---|
    4 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    3 |###|   |#?#|   |###|   |###|   |
      |---|---|---|---|---|---|---|---|
    2 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    1 |#?#|   |###|   |###|   |###|   |
      +---+---+---+---+---+---+---+---+
        A   B   C   F   E   F   G   H

    For cell1 = "A1" and cell2 = "H3", the output should be
    solution(cell1, cell2) = false.

      +---+---+---+---+---+---+---+---+
    8 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    7 |###|   |###|   |###|   |###|   |
      |---|---|---|---|---|---|---|---|
    6 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    5 |###|   |###|   |###|   |###|   |
      |---|---|---|---|---|---|---|---|
    4 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    3 |###|   |###|   |###|   |###| ? |
      |---|---|---|---|---|---|---|---|
    2 |   |###|   |###|   |###|   |###|
      |---|---|---|---|---|---|---|---|
    1 |#?#|   |###|   |###|   |###|   |
      +---+---+---+---+---+---+---+---+
        A   B   C   F   E   F   G   H

    Guaranteed constraints:
    cell1.length = 2,
    'A' ≤ cell1[0] ≤ 'H',
    1 ≤ cell1[1] ≤ 8.
    cell2.length = 2,
    'A' ≤ cell2[0] ≤ 'H',
    1 ≤ cell2[1] ≤ 8.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

bool solution(string cell1, string cell2)
{
    var chessboard = new Dictionary<string, string>();
    int size = 8;

    for (var row = 0; row < size; row++)
    {
        for (var column = 0; column < size; column++)
        {
            // Letters represent rows, starting from A
            var letter = (char)('A' + row);
            // Numbers represent columns, starting from 1
            var number = column + 1;
            var cell = $"{letter}{number}";
            // Populates the chessboard Dictionary with the cell as the Key,
            // and the color as its Value. Starting with A1 in Black.
            // When row = 0, colum = 0, then color = (0 + 0) = 0 = Black (even)
            // When row = 0, colum = 1, then color = (0 + 1) = 1 = White (odd)
            // ...
            // When row = 1, colum = 0, then color = (1 + 0) = 1 = White (odd)
            // When row = 1, colum = 1, then color = (1 + 1) = 2 = Black (even)
            // ...
            // Therefore when (row + column) is even the color is Black, and
            // when (row + column) is odd the color is White.
            chessboard[cell] = (row + column) % 2 == 0 ? "Black" : "White";
        }
    }

    chessboard.TryGetValue(cell1, out var color1);
    chessboard.TryGetValue(cell2, out var color2);
    
    return color1 == color2;
}
