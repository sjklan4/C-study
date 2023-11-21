// for(초기식; 조건식; 증감식){}

// 짝수 구하기 

using System;

class ForSum
{
    static void Main()
    {
        int n = 5;
        int sum = 0;

        for (int i = 1; i <= n; i++) 
        {
            if (i % 2 == 0)
            {
                sum += i; // 짝수 0,2,4 더하기
            }

        }
        Console.WriteLine($" 1부터 {n}까지 짝수의 합 : {sum}");
    }
}