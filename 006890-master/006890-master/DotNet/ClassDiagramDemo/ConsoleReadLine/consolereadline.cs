using System;

class ReadLineDemo
{
    static void Main()
    {
        // Console.Write("이름 : _______\b\b\b\b\b\b\b"); 
        // string name =  Console.ReadLine();
        // Console.WriteLine($"{name}님 안녕하세요.");

        // int x = Console.Read(); // 아스키코드 : 아스키 코드를 받고 
        // Console.WriteLine(x); //그 코드 번호를 출력한다음 아래 실 문자 출력
        // Console.WriteLine(Convert.ToChar(x)); //실제 문자   

        //Console.WriteLine("정수: ");
        //string num = Console.ReadLine(); // 문자형 인식
        //int number = Convert.ToInt32(num);
        //Console.WriteLine(number); // 위에 인식한 문자형을 정수형으로 다시 인식

        //int number = 10; // -> 0000 101011
        //Console.WriteLine(Convert.ToString(number, 2)); //2진수 수로 바꾸는 구문
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(8,'0')); // 2진수 앞을 0으로 해서 총 8자리표현

        Console.WriteLine(Convert.ToInt32("00001010", 2));
        
    }

}