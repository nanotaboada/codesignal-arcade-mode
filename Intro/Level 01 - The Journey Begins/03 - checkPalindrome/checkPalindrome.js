/*  
    Problem
    --------------------------------------------------------------------------------
    Given the string, check if it is a palindrome.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    A "palindrome" is a word, phrase, or sequence that reads the same backwards
    as forwards (e.g. madam or nurses run).
    A way to solve the problem would be to literally reverse the provided text.
*/

function solution(inputString) {
    
    let forwards = inputString.toLowerCase().replaceAll(' ', '');
    let backwards = forwards.split('').reverse().join('');
    
    return forwards === backwards;
}