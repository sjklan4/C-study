//비교 연산자
// >,<,>=,==(같은지), !=
using System;

public class relationOP
{
    public static void Main()
    {
        int firstNum = 10;
        int secondNum = 5;
        bool r = false;

        Console.WriteLine(firstNum > secondNum); 

        r = (firstNum <= secondNum); // false
        Console.WriteLine(r);
    }
}