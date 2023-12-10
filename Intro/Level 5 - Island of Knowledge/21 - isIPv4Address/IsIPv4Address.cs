/*  
    Problem
    --------------------------------------------------------------------------------
    An IP address is a numerical label assigned to each device (e.g., computer,
    printer) participating in a computer network that uses the Internet Protocol
    for communication. There are two versions of the Internet protocol, and thus
    two versions of addresses. One of them is the IPv4 address.
    
    Given a string, find out if it satisfies the IPv4 address naming rules.

    Example
    
    For inputString = "172.16.254.1", the output should be
    solution(inputString) = true;
    
    For inputString = "172.316.254.1", the output should be
    solution(inputString) = false.
    316 is not in range [0, 255].
    
    For inputString = ".254.255.0", the output should be
    solution(inputString) = false.
    There is no first number.
*/

/*  
    Solution
    --------------------------------------------------------------------------------
*/

bool solution(string inputString)
{
    // https://stackoverflow.com/questions/5284147/validating-ipv4-addresses-with-regexp
    const string pattern = "^((25[0-5]|(2[0-4]|1\\d|[1-9]|)\\d)\\.?\\b){4}$";
    var regex = new Regex(pattern, RegexOptions.IgnoreCase);
    
    return regex.IsMatch(inputString);
}