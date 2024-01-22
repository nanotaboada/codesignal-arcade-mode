/*  
    Problem
    --------------------------------------------------------------------------------
    You have deposited a specific amount of money into your bank account.
    Each year your balance increases at the same growth rate. With the
    assumption that you don't make any additional deposits, find out how long
    it would take for your balance to pass a specific threshold.
    
    Example
    
    For deposit = 100, rate = 20, and threshold = 170, the output should be
    solution(deposit, rate, threshold) = 3.
    
    Each year the amount of money in your account increases by 20%.
    So throughout the years, your balance would be:
    
    year 0: 100;
    year 1: 120;
    year 2: 144;
    year 3: 172.8.
    
    Thus, it will take 3 years for your balance to pass the threshold,
    so the answer is 3.

    Guaranteed constraints:
    1 ≤ deposit ≤ 100.
    1 ≤ rate ≤ 100.
    deposit < threshold ≤ 200.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    The decimal type is appropriate when the required degree of precision is
    determined by the number of digits to the right of the decimal point.
    Such numbers are commonly used in financial applications, for currency
    amounts (for example, $1.00), interest rates (for example, 2.625%),
    and so forth.
    Even numbers that are precise to only one decimal digit are handled more
    accurately by the decimal type: 0.1, for example, can be exactly
    represented by a decimal instance, while there's no double or float instance
    that exactly represents 0.1. Because of this difference in numeric types,
    unexpected rounding errors can occur in arithmetic calculations when you use
    double or float for decimal data.

    https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
*/

int solution(int deposit, int rate, int threshold)
{
    int years = 0;

    decimal balance = deposit;
    decimal interestRate = rate / 100.0m;

    while (balance < threshold)
    {
        balance += balance * interestRate;
        years++;

        if (balance >= threshold)
        {
            break;
        }
    }

    return years;
}