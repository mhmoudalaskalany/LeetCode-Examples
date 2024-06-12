var str = Console.ReadLine();
if(str == null)
{
    return;
}
var length = str.Length;
var isPalindrome = true;
for(int i = 0 ; i < length / 2 ; i ++)
{
    if(str[i] != str[length - 1 - i])
    {
        isPalindrome = false;
        break;
    }
}

Console.WriteLine(isPalindrome ? "Is Palindrome" : "Not Palindrome");