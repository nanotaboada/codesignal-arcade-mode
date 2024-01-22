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

int solution(int[] statues) {  // [6, 2, 3, 8]

    Arrays.sort(statues); // [2, 3, 6, 8]

    int smallest = statues[0]; // 2
    int largest = statues[statues.length - 1]; // 8
    int additional = 0;

    for (int i = smallest; i < largest; i++) {
        // https://www.freecodecamp.org/news/how-to-use-arrays-binarysearch-in-java/
        if (Arrays.binarySearch(statues, i) < 0) { // i = 2, 3, 4, 5, 6 and 7
            additional++; // i = 4, 5 and 7
        }
    }

    return additional; // 3
}


