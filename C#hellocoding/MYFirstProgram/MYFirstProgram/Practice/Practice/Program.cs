// using System;

// namespace ConsoleWrite
// {
// class Program
// {
// static void Main(string[] args)
// {
// Console.Write(무엇이 무엇이");
// Console.WriteLine("문제일까");
// Console.Write("\" ");

// }
// }
// }
// 출력결과 ?!"
// """""
// 심화 문제 풀이

using System;

namespace ConsoleWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("무엇이 무엇이"); // " 빠짐
            Console.WriteLine("문제일까?");// 문제없음
            Console.WriteLine("?!\""); // " " 사이 부호 바꿔야 하고 줄바꿈 되어있으니 WriteLine
            Console.WriteLine("\"\"\"\"");
        }
    }
}