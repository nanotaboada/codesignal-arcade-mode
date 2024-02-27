/*  
    Problem
    --------------------------------------------------------------------------------
    Given an integer product, find the smallest positive (i.e. greater than 0)
    integer the product of whose digits is equal to product. If there is no such
    integer, return -1 instead.

    Example

    For product = 12, the output should be solution(product) = 26;
    For product = 19, the output should be solution(product) = -1.

    Guaranteed constraints:
    0 ≤ product ≤ 600.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    
*/

int solution(int product)
{
    if (product == 0) return 10;
    if (product < 10) return product;

    for (var integer = 1; integer <= 9999; integer++)
    {
        var number = integer;
        var digits = new List<int>();

        while (number > 0)
        {
            var digit = number % 10;
            digits.Add(digit);
            number /= 10;
        }
        
        var multiplication = 1;
        
        foreach (var digit in digits)
        {
            multiplication = multiplication *= digit; 
        }

        if (multiplication == product)
        {
            return integer;
        }
    }

    return -1;
}
