/*  
    Problem
    --------------------------------------------------------------------------------
    An email address such as "John.Smith@example.com" is made up of a local part
    ("John.Smith"), an "@" symbol, then a domain part ("example.com").
    
    The domain name part of an email address may only consist of letters, digits,
    hyphens and dots. The local part, however, also allows a lot of different
    special characters. Here (https://en.wikipedia.org/wiki/Email_address#Examples)
    you can look at several examples of correct and incorrect email addresses.

    Given a valid email address, find its domain part.

    Guaranteed constraints:
    10 ≤ address.length ≤ 50.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
    According to https://en.wikipedia.org/wiki/Email_address#Examples, the
    following example is a valid email address:

    "very.(),:;<>[]\".VERY.\"very@\\ \"very\".unusual"@strange.example.com

    Test 7 proposes a similar unusual case:

    address: "\"very.unusual.@.unusual.com\"@usual.com"
*/

string solution(string address)
{
    var domain = string.Empty;

    // https://regex101.com/r/Y3F54d/1
    var pattern = @"@([^@]+)$";
    var regex = new Regex(pattern);
    var match = regex.Match(address);

    if (match.Success)
    {
        // This will handle Test 7
        // address: "\"very.unusual.@.unusual.com\"@usual.com"
        domain = match.Groups[1].Value;
    }
    
    return domain;
}
