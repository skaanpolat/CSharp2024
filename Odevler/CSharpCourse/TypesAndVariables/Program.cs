
//Console.WriteLine("Hello, World!");
//Value Type
double number5 = 10.5;
decimal number6 = 10;
char charachter = 'A';
bool condition = true;
byte number4 = 255;
int number1 = 2147483647;
long number2 = 9223372036854775807;
short number3 = 32767;
var number7 = 10;
number7 = 'A';
//number7 = "A";


Console.WriteLine("Number 1 is {0}", number1);
Console.WriteLine("Number 2 is {0}", number2);
Console.WriteLine("Number 3 is {0}", number3);
Console.WriteLine("Number 4 is {0}", number4);
Console.WriteLine("Number 5 is {0}", number5);
Console.WriteLine("Number 7 is {0}", number7);
Console.WriteLine("Characther is : {0}", (int)charachter);

Console.WriteLine((int)Days.Friday);

enum Days
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}