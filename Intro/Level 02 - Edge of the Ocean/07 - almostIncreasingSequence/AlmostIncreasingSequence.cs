/*  
    Problem
    --------------------------------------------------------------------------------
    Given a sequence of integers as an array, determine whether it is possible
    to obtain a strictly increasing sequence by removing no more than one
    element from the array.

    Note: sequence a0, a1, ..., an is considered to be a strictly increasing
    if a0 < a1 < ... < an. Sequence containing only one element is also considered
    to be strictly increasing.

    Example

    For sequence = [1, 3, 2, 1], the output should be solution(sequence) = false.

    There is no one element in this array that can be removed in order to get a
    strictly increasing sequence.

    For sequence = [1, 3, 2], the output should be solution(sequence) = true.

    You can remove 3 from the array to get the strictly increasing sequence [1, 2].
    Alternately, you can remove 2 to get the strictly increasing sequence [1, 3].

    Guaranteed constraints:
    2 ≤ sequence.length ≤ 105,
    -105 ≤ sequence[i] ≤ 105.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

bool solution(int[] sequence)
{
    var decreases = 0;
    
    for (var i = 0; i < sequence.Length - 1; i++)
    {
        if (sequence[i] - sequence[i + 1] >= 0)
        {
            decreases += 1;

            if (i - 1 >= 0
                && i + 2 <= sequence.Length - 1
                && sequence[i] - sequence[i + 2] >= 0
                && sequence[i - 1] - sequence[i + 1] >= 0)
            {
                return false;
            }
        }
    }

    return decreases <= 1;
}
