// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Checking if Number is Palindrome Without Converting To String!");
var strNumber = Console.ReadLine();
int sum = 0;
int remaining;
int number;

if (strNumber == null)
{
    return;
}
number = int.Parse(strNumber);
int temp = number;
while (number > 0)
{
    remaining = number % 10; //example 112211 this will give 11221.1 1 is the remaining 
    sum = (sum * 10) + remaining; // this will take 0 * 10 = 0 + 1 the remaining = 1
    number = number / 10; // 112211 /10 = 11221.1 and since this is integer it will be 11221 then next loop will be 11221 % 10 which give 1122.1
}
Console.WriteLine(temp == sum ? "Number Is Palindrome !" : "Number Is Not Palindrome!!");
