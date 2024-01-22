
/*  
    Problem
    --------------------------------------------------------------------------------
    Several people are standing in a row and need to be divided into two teams.
    The first person goes into team 1, the second goes into team 2, the third
    goes into team 1 again, the fourth into team 2, and so on.

    You are given an array of positive integers - the weights of the people.
    Return an array of two integers, where the first element is the total
    weight of team 1, and the second element is the total weight of team 2
    after the division is complete.

    Example

    For a = [50, 60, 60, 45, 70], the output should be
    solution(a) = [180, 105].

    Guaranteed constraints:
    1 ≤ a.length ≤ 105,
    45 ≤ a[i] ≤ 100.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    a[0] (even) team 1
    a[1] (odd)  team 2 
    a[2] (even) team 1 
    a[3] (odd)  team 2
    ...
*/

int[] solution(int[] a)
{
    var team1 = a
        .Where((element, index) => index % 2 == 0)
        .Sum();

    var team2 = a
        .Where((element, index) => index % 2 != 0)
        .Sum();

    return new int[] { team1, team2 };
}
