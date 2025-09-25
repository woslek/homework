using System;

namespace ConsoleWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WriteLine을 쓰면");
            Console.WriteLine("한 줄씩 나옵니다.");
            Console.Write("Write를 쓰면 아닙니다.");
            Console.Write("이어져서 나오죠?");
            Console.WriteLine("Write 뒤에 WriteLine을 썼습니다.");
            // Console.Write () 함수는 출력 뒤에 새줄을 만들지 않는다.

            Console.Write("바구니 안에 담긴 사과의 개수:");
            Console.WriteLine(12);

            Console.Write("사과 바구니의 무게:");
            Console.WriteLine(1.32);
            // 숫자의 경우 "" '' 필요없지만 특수문자는 필요함
            Console.WriteLine("!!?#$%");

            Console.WriteLine("큰따옴표\" 출력");//큰따옴표 출력 ( \ 줄바꿈 파이썬과 동일)
                                           //큰 따옴표를 출력하려고 시도
            Console.WriteLine("\\\'\"");
        }
    }
}