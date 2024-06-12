
var str = Console.ReadLine();
if(str == null)
{
    return;
}
char[] reversed = str.ToCharArray();
Array.Reverse(reversed);
string reversedStr = new string(reversed);
Console.WriteLine(reversedStr == str ? "Is Palindrome" : "Not Palindrome");