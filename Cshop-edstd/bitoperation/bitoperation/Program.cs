using System;
using static System.Console;

class Bit
{
    static void Main()
    {
        // & 연산자 : 비트 AND 연산자(둘다 1일때만 1)
        byte x = 0b1010; //10
        byte y = 0b1100; //12

        WriteLine($"  {Convert.ToString(x, 2)}  -> {x} ");
        WriteLine($"& {Convert.ToString(y, 2)} -> {y} ");
        WriteLine($" ------- ");
        WriteLine($"  {Convert.ToString(x & y, 2)}  -> {x & y, 2}");

        // | 연산자 : 비트 OR 연산자(하나라도 1이면 1)
        byte a = 0b1010; //10
        byte b = 0b1100; //12

        Console.WriteLine($"  {Convert.ToString(a, 2)}  -> {a} ");
        Console.WriteLine($"| {Convert.ToString(b, 2)} -> {b} ");
        Console.WriteLine($" ------- ");
        Console.WriteLine($"  {Convert.ToString(a | b, 2)}  -> {a | b, 2}");

        // ^ 연산자 : 비트 XOR 연산자(서로 다르면 1)
        byte c = 0b1010; //10
        byte d = 0b1100; //12

        Console.WriteLine($"  {Convert.ToString(c, 2)}  -> {c} ");
        Console.WriteLine($"^ {Convert.ToString(d, 2)} -> {d} ");
        Console.WriteLine($" ------- ");
        Console.WriteLine($"  {Convert.ToString(c ^ d, 2).PadLeft(4,'0')}  -> {c ^ d,2}");

        // ~ 연산자 : 비트 NOT 연산자(1<->0, 비트 반전)
        byte D = 0b00001010; //10
       

        Console.WriteLine($"~  {Convert.ToString(D, 2)}.PadLeft(8, '0')}}  -> {D,3} ");
        Console.WriteLine($" ------- ");
        Console.WriteLine($"  {Convert.ToString((byte)~D, 2).PadLeft(8, '0')}  -> {~D,3}");

    }

}


