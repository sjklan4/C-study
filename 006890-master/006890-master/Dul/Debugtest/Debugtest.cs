using System;

class DebugDemo
{ 
    static void Main()
    {
        // int number1 = 10;
        // int number2 = 20;
        // int number3 = 30;

        // Console.WriteLine(number1);
        // Console.WriteLine(number2);
        // Console.WriteLine(number3); 
        int a, b, c, r;
        a = 3;
        b = 5;
        c = 7;

        r = a-- - ++b * c++;
        Console.WriteLine("r : {0}, a : {1}, b : {2}, c :{3}", r,a,b,c);
    }
}