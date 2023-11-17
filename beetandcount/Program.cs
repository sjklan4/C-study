// &연산자 : 비트and 여산자

    
class BitAnd
{
    static void Main()
    {
        byte x = 0b1010; // 10
        byte y = 0b1100; // 12
       

        Console.WriteLine($" {Convert.ToString(x, 2)}");
        Console.WriteLine($"& {Convert.ToString(y, 2)}");
        Console.WriteLine($"  {Convert.ToString(x & y, 2)}");
    }

}