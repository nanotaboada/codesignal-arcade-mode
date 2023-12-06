/*  
    Problem
    --------------------------------------------------------------------------------
    Some people are standing in a row in a park. There are trees between them
    which cannot be moved. Your task is to rearrange the people by their heights
    in a non-descending order without moving the trees. People can be very tall!
    
    Example
    
    For a = [-1, 150, 190, 170, -1, -1, 160, 180], the output should be
    solution(a) = [-1, 150, 160, 170, -1, -1, 180, 190].

    Guaranteed constraints:
    1 ≤ a.length ≤ 1000,
    -1 ≤ a[i] ≤ 1000.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

int[] solution(int[] a)
{
    var tree = -1;

    // Filter trees and sort (non-descending) people 
    var people = a
        .Where(element => element != tree)
        .OrderBy(element => element)
        .ToArray();

    var person = 0;

    for (var i = 0; i < a.Length; i++)
    {
        // If it's not a tree then it's a person
        if (a[i] != tree)
        {
            // Assign the first (ordered) person
            a[i] = people[person];
            // Move to the next person
            person++;
        }
    }
    
    return a;
}
