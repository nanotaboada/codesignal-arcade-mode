/*
    Problem
    --------------------------------------------------------------------------------
    Below we will define an n-interesting polygon. Your task is to find the
    area of a polygon for a given n. A 1-interesting polygon is just a square
    with a side of length 1. An n-interesting polygon is obtained by taking the
    n - 1-interesting polygon and appending 1-interesting polygons to its rim,
    side by side. You can see the 1-, 2-, 3- and 4-interesting polygons in the
    picture below:

                                                   X
                                X                X X X
                 X            X X X            X X X X X
      X        X X X        X X X X X        X X X X X X X
                 X            X X X            X X X X X
                                X                X X X
                                                   X
    n = 1      n = 2          n = 3              n = 4

    Guaranteed constraints:
    1 ≤ n < 104.
*/

/*
    Solution
    --------------------------------------------------------------------------------
    The trick here is to see the n-interesting polygon as composed by 2 squares:

                                                   X
                                X                X O X
                 X            X O X            X O X O X
      X        X O X        X O X O X        X O X O X O X
                 X            X O X            X O X O X
                                X                X O X
                                                   X
    n = 1      n = 2          n = 3              n = 4

    A square is a 2D figure in which all the sides are of equal measure. Since
    all the sides are equal, the area would be length times width, which is
    equal to side × side.

    Keep in mind that, if the side made of Xs meassures n, then the side made
    with Os meassures n - 1.

    So to solve the problem we can now:
    - Calculate the area of the square made of Xs (n * n)
    - Calculate the area of the square made of Os (n - 1 * n - 1)
    - Add both results (n * n) + (n - 1 * n - 1)

    n = 1
    (1 * 1) + (0 * 0) = 1 + 0 = 1

    n = 2
    (2 * 2) + (1 * 1) = 4 + 1 = 5
    
    n = 3
    (3 * 3) + (2 * 2) = 9 + 4 = 13
    
    n = 4
    (4 * 4) + (3 * 3) = 16 + 9 = 25
*/

int solution(int n) {
    return (n * n) + (n - 1) * (n - 1);
}

