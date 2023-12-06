/*  
    Problem
    --------------------------------------------------------------------------------
    Given a rectangular matrix of characters, add a border of asterisks(*) to it.
    
    Example
    
    For
    picture = ["abc",
               "ded"]

    the output should be
    solution(picture) = ["*****",
                         "*abc*",
                         "*ded*",
                         "*****"]

    Guaranteed constraints:
    1 ≤ picture.length ≤ 100,
    1 ≤ picture[i].length ≤ 100.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

string[] solution(string[] picture)
{
    var framed = new List<string>();
    var border = new string('*', picture[0].Length + 2);
    
    framed.Add(border);

    foreach (var element in picture)
    {
        framed.Add('*' + element + '*');
    }

    framed.Add(border);
    
    return framed.ToArray();
}
