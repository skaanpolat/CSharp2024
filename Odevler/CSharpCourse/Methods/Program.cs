﻿//Add();
//var result = Add2(20);

//Console.WriteLine(result);

//int number1;
//int number2 = 100;
//var result2 = Add3(out number1, number2);
//Console.WriteLine(result2);
//Console.WriteLine(number1);

Console.WriteLine(Add4(9,1,2,3,4,5));

Console.WriteLine(Multiply(2, 4));

//Console.WriteLine(Multiply(1, 5, 7));

Console.ReadLine();


static void Add()
{
    Console.WriteLine("Added!!!!");
}

static int Add2(int number1, int number2 = 30)
{
    var result = number1 + number2;

    return result;
}

static int Add3(out int number1, int number2 = 30)
{
    number1 = 30;
    return number1 + number2;
}

static int Multiply(int number1, int number2)
{
    return number1 * number2;
}


//static int Multiply(int number1, int number2, int number3)
//{
//    return number1 * number2 * number3;
//}

static int Add4(int number, params int[] numbers)
{
    return numbers.Sum();
}

