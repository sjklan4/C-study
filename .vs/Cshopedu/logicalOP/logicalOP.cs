//논리 연산자
// && 연산자(AND) : 둘 다 참일때에만 참, 즉, 하나라도 거짓이면 거짓
// 연산자(OR) : 하나라도 참이면 참, 즉 둘 다 거짓일때에만 거짓
// 연산자(not) : 참이면 거짓으로, 거짓이면 참으로


using System;

public class LogicalOP
{
    public static void Main()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i ==3) && (j !=3 ); //r = true && true => true 
        Console.WriteLine(r); //true

        r = (i != 3) || (j == 3); //r = false || false => false
        Console.WriteLine(r); // false

        r = (i >= 5); // r => false
        Console.WriteLine("{0}", !r); //false -> true
    }

}