/*  
    Problem
    --------------------------------------------------------------------------------
    Two arrays are called similar if one can be obtained from another by
    swapping at most one pair of elements in one of the arrays.
    
    Given two arrays a and b, check whether they are similar.
    
    Example
    
    For a = [1, 2, 3] and b = [1, 2, 3], the output should be
    solution(a, b) = true.
    
    The arrays are equal, no need to swap any elements.
    
    For a = [1, 2, 3] and b = [2, 1, 3], the output should be
    solution(a, b) = true.
    
    We can obtain b from a by swapping 2 and 1 in b.
    
    For a = [1, 2, 2] and b = [2, 1, 1], the output should be
    solution(a, b) = false.
    
    Any swap of any two elements either in a or in b won't make a and b equal.

    Guaranteed constraints:
    b.length = a.length,
    1 ≤ b[i] ≤ 1000.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

bool solution(int[] a, int[] b)
{    
    var differences = new List<int>();

    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] != b[i])
        {
            // Store the index where there is a difference
            differences.Add(i);
        }
    }

    // No differences
    if(!differences.Any())
    {
        return true;
    }
    // Exactly 2 differences
    else if (differences.Count == 2)
    {
        /*
            Check if there is a swappable pair.
            For example, given:
            a [ 0, 1, 1, 2, 3, 5, 8 ]
            b [ 0, 1, 8, 2, 3, 5, 1 ]
            If the 1st difference occurred at Index 2 and the 2nd at Index 6
            a[2] = 1, b[2] = 8 and
            a[6] = 8, b[6] = 1
            Swapping those indexes should give us the expected matching values
        */

        // a[2] == b[6]
        //  (1) ==  (1)  
        var firstSwap = a[differences[0]] == b[differences[1]];
        // b[2] == a[6]
        //  (8) ==  (8)
        var secondSwap = b[differences[0]] == a[differences[1]];

        return firstSwap && secondSwap;
    }
    // No swappable pair
    else
    {
        return false;
    }
}
