/*  
    Problem
    --------------------------------------------------------------------------------
    Given an array of integers, find the pair of adjacent elements that has the
    largest product and return that product.

    Example
    
    For inputArray = [3, 6, -2, -5, 7, 3], the output should be
    solution(inputArray) = 21.
    
    7 and 3 produce the largest product.

    Guaranteed constraints:
    2 ≤ inputArray.length ≤ 10,
    -1000 ≤ inputArray[i] ≤ 1000.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    Initially, we store the product of the first pair of values (index 0 and 1)
    as the current maximum value.

    To iterate through all the elements we create a for loop starting from our
    second value (index 1) until the "the length minus 1".

    In the following example: [0, 1, 1, 2, 3, 5, 8, 13, 21]
    the length of the array is 9, therefore its last index is 8.

    --------------------------
    | Length | Index | Value |
    --------------------------
    |   1   |   0   |    0   |
    |   2   |   1   |    1   |
    |   3   |   2   |    1   |
    |   4   |   3   |    2   |
    |   5   |   4   |    3   |
    |   6   |   5   |    5   |
    |   7   |   6   |    8   |
    |   8   |   7   |    13  |
    |   9   |   8   |    21  |
    --------------------------

    Then we just have to multiply the next two values (i and i + 1) and
    compare with the one we initially stored.

    If the resulting value is larger then we update the stored value with
    the new largest product.
    
    After the iteration ends we just return the stored value.
*/

function solution(inputArray) {
    
    let largestProduct = inputArray[0] * inputArray[1];

    for (let i = 1; i < inputArray.length -1; i++) {

        let product = inputArray[i] * inputArray[i + 1];
        
        if (product > largestProduct) {
            largestProduct = product;
        }
    }
    
    return largestProduct;
}