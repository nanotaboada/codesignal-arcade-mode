/*  
    Problem
    --------------------------------------------------------------------------------
    Consider integer numbers from 0 to n - 1 written down along the circle in
    such a way that the distance between any two neighboring numbers is equal
    (note that 0 and n - 1 are neighboring, too).

    Given n and firstNumber, find the number which is written in the radially
    opposite position to firstNumber.

    Example

        1   2
      0       3
     9         4
      8       5
        7   6

    For n = 10 and firstNumber = 2, the output should be
    solution(n, firstNumber) = 7.

    For n = 10 and firstNumber = 7, the output should be
    solution(n, firstNumber) = 2.

*/

/*  
    Solution
    --------------------------------------------------------------------------------
    - Calculate the diameter, which is half the circumference
    (n / 2)

    - Move to firstNumber
    (n / 2) + firstNumber

    - Apply modulo n to ensure the result stays within the circle:
    ((n / 2) + firstNumber) % n

    Example

    (10 / 2) = 5
    5 + 7 = 12
    12 % 10 = 2
*/

int solution(int n, int firstNumber)
{
    return ((n / 2) + firstNumber) % n;
}