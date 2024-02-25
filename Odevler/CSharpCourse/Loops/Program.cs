internal class Program
{
    private static void Main(string[] args)
    {
        //forloop();
        //whileloop();
        //dowhlileloop();
        //foreachloop();

        if (isPrimeNumber(7))
        {
            Console.WriteLine("This is a Prime number!");
        }
        else
        {
            Console.WriteLine("This is not a Prime number!");
        }

    }


    private static bool isPrimeNumber(int number)
    {

        bool result = true;

        for (int i = 2; i < number-1; i++)
        {
            if (number%i==0)
            {
                result = false;
                i = number;
            }
        }

        return result;

    }


    private static void foreachloop()
    {
        string[] students = { "Engin", "Derin", "Salih" };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static int dowhlileloop()
    {

        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;

        } while (number >= 11);
        return number;
    }

    private static void whileloop()
    {
        int number = 100;

        while (number > 0)
        {
            Console.WriteLine(number);
            number--;
            Console.WriteLine("Now number is {0}", number);
        }
    }

    private static void forloop()
    {
        for (int i = 100; i >= 0; i -= 2)
        {
            Console.WriteLine(i);
        }
    }
}