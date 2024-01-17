/*  
    Problem
    --------------------------------------------------------------------------------
    Ratiorg got statues of different sizes as a present from CodeMaster for his
    birthday, each statue having an non-negative integer size. Since he likes to
    make things perfect, he wants to arrange them from smallest to largest so that
    each statue will be bigger than the previous one exactly by 1. He may need some
    additional statues to be able to accomplish that. Help him figure out the
    minimum number of additional statues needed.

    Example

    For statues = [6, 2, 3, 8], the output should be solution(statues) = 3.

    Ratiorg needs statues of sizes 4, 5 and 7.

    Guaranteed constraints:
    1 ≤ statues.length ≤ 10,
    0 ≤ statues[i] ≤ 20.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

function solution(statues) { // [6, 2, 3, 8]

    statues.sort((a, b) => a - b); // [2, 3, 6, 8]

    const smallest = statues[0]; // 2
    const largest = statues[statues.length - 1]; // 8
    let additional = 0;

    for (let i = smallest; i < largest; i++) { 
        // https://www.freecodecamp.org/news/4-methods-to-search-an-array/
        if (!statues.includes(i)) { // i = 2, 3, 4, 5, 6 and 7
            additional++; // i = 4, 5 and 7
        }
    }

    return additional; // 3
}



